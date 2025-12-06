using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SATS_TestTask
{
    public interface IUserOrganizationService
    {
        Task<List<Security.Models.OrganizationItem>> GetPositionsForUserAsync(Security.Models.User user);
        Task<List<Security.Models.User>> GetUsersByPositionAsync(Security.Models.OrganizationItem orgItem);
    }

    public class UserOrganizationService : IUserOrganizationService
    {
        private readonly Dictionary<long, Security.Models.OrganizationItem> _orgById;

        public UserOrganizationService()
        {
            _orgById = Data.OrganizationItems.ToDictionary(i => i.Id, i => i);
        }

        private static List<long> ParsePositionHash(string positionHash)
        {
            var res = new List<long>();
            if (string.IsNullOrWhiteSpace(positionHash))
                return res;

            var parts = positionHash.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in parts)
            {
                if (long.TryParse(p.Trim(), out var id))
                    res.Add(id);
            }
            return res;
        }

        public async Task<List<Security.Models.OrganizationItem>> GetPositionsForUserAsync(Security.Models.User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            await Task.Yield();

            var ids = ParsePositionHash(user.positionHash);

            var positions = new List<Security.Models.OrganizationItem>();
            foreach (var id in ids)
            {
                if (_orgById.TryGetValue(id, out var orgItem))
                {
                    positions.Add(orgItem);
                }
            }

            return positions;
        }

        public async Task<List<Security.Models.User>> GetUsersByPositionAsync(Security.Models.OrganizationItem orgItem)
        {
            if (orgItem == null)
                return new List<Security.Models.User>();

            await Task.Yield();

            var targetId = orgItem.Id;

            var matchedUsers = Data.Users
                .Where(u =>
                {
                    var ids = ParsePositionHash(u.positionHash);
                    return ids.Contains(targetId);
                })
                .ToList();

            return matchedUsers;
        }
    }
}
