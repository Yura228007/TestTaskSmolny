using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SATS_TestTask
{
    public static class OrganizationHelpers
    {
        public static async Task<List<Security.Models.OrganizationItem>> GetAllDepartmentsForUserAsync(
            IUserOrganizationService userOrgService,
            Security.Models.User user)
        {
            if (userOrgService == null) throw new ArgumentNullException(nameof(userOrgService));
            if (user == null) throw new ArgumentNullException(nameof(user));

            var positions = await userOrgService.GetPositionsForUserAsync(user);
            if (positions == null || positions.Count == 0)
                return new List<Security.Models.OrganizationItem>();

            var orgById = Data.OrganizationItems.ToDictionary(i => i.Id, i => i);

            var foundDeptIds = new HashSet<long>();
            var result = new List<Security.Models.OrganizationItem>();

            foreach (var pos in positions)
            {
                if (pos == null) continue;

                if (pos.orgItemType == Security.Types.OrganizationItemType.Department)
                {
                    if (foundDeptIds.Add(pos.Id))
                        result.Add(pos);
                    continue;
                }

                var currentParentId = pos.Parent;
                while (currentParentId != null)
                {
                    if (!orgById.TryGetValue(currentParentId.Value, out var parentItem))
                        break;

                    if (parentItem.orgItemType == Security.Types.OrganizationItemType.Department)
                    {
                        if (foundDeptIds.Add(parentItem.Id))
                            result.Add(parentItem);
                        break;
                    }

                    currentParentId = parentItem.Parent;
                }
            }

            return result;
        }

        public static async Task<List<Security.Models.User>> SortUsersByPositionLevelAsync(
            IUserOrganizationService userOrgService,
            IEnumerable<Security.Models.User> users)
        {
            if (userOrgService == null) throw new ArgumentNullException(nameof(userOrgService));
            if (users == null) throw new ArgumentNullException(nameof(users));

            var orgById = Data.OrganizationItems.ToDictionary(i => i.Id, i => i);

            var depth = new Dictionary<long, int>();
            var queue = new Queue<Security.Models.OrganizationItem>();

            foreach (var item in Data.OrganizationItems)
            {
                if (item.Parent == null)
                {
                    depth[item.Id] = 0;
                    queue.Enqueue(item);
                }
            }

            while (queue.Count > 0)
            {
                var cur = queue.Dequeue();
                var curDepth = depth[cur.Id];
                foreach (var child in Data.OrganizationItems.Where(x => x.Parent == cur.Id))
                {
                    if (!depth.ContainsKey(child.Id))
                    {
                        depth[child.Id] = curDepth + 1;
                        queue.Enqueue(child);
                    }
                }
            }

            var userLevels = new List<(Security.Models.User user, int level)>();

            foreach (var user in users)
            {
                var positions = await userOrgService.GetPositionsForUserAsync(user);

                int userMinLevel = int.MaxValue;
                if (positions != null)
                {
                    foreach (var pos in positions)
                    {
                        if (pos == null) continue;

                        if (depth.TryGetValue(pos.Id, out var lvl))
                        {
                            if (lvl < userMinLevel) userMinLevel = lvl;
                        }
                        else
                        {
                            long? curParent = pos.Parent;
                            int extra = 1;
                            while (curParent != null)
                            {
                                if (depth.TryGetValue(curParent.Value, out var pLvl))
                                {
                                    var computed = pLvl + extra;
                                    if (computed < userMinLevel) userMinLevel = computed;
                                    break;
                                }

                                if (!orgById.TryGetValue(curParent.Value, out var parentItem))
                                    break;
                                curParent = parentItem.Parent;
                                extra++;
                            }
                        }
                    }
                }

                userLevels.Add((user, userMinLevel));
            }

            var sorted = userLevels
                .OrderBy(t => t.level)
                .ThenBy(t => t.user.id)
                .Select(t => t.user)
                .ToList();

            return sorted;
        }
    }
}
