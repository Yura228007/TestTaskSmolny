using SATS_TestTask;
using System;
using System.Linq;
using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        IUserOrganizationService userOrgService = new UserOrganizationService();

        var user = Data.Users.First(u => u.login == "dd_smirnov"); 

        Console.WriteLine("=== Task 1 ===");
        await DemoTask1(userOrgService, user);

        Console.WriteLine("\n=== Task 2 ===");
        await DemoTask2(userOrgService, user);

        Console.WriteLine("\n=== Task 3 ===");
        await DemoTask3(userOrgService, user);

        Console.WriteLine("\n=== Task 4 ===");
        await DemoTask4(userOrgService);
    }

    // ---------------- Task 1 ----------------
    private static async Task DemoTask1(IUserOrganizationService userOrgService, Security.Models.User user)
    {
        Console.WriteLine($"User: {user.fullName}");

        var positions = await userOrgService.GetPositionsForUserAsync(user);

        Console.WriteLine("User Positions:");
        foreach (var pos in positions)
            Console.WriteLine($"- {pos.Name}");

        Console.WriteLine("\nUsers by the position of '???????????':");

        var developerItem = Data.OrganizationItems.FirstOrDefault(o => o.Name == "???????????");
        var developers = await userOrgService.GetUsersByPositionAsync(developerItem);

        foreach (var dev in developers)
            Console.WriteLine($"- {dev.fullName}");
    }

    // ---------------- Task 2 ----------------
    private static async Task DemoTask2(IUserOrganizationService userOrgService, Security.Models.User user)
    {
        var departments = await OrganizationHelpers.GetAllDepartmentsForUserAsync(userOrgService, user);

        Console.WriteLine($"User: { user.fullName}");
        Console.WriteLine("User Departments:");

        foreach (var d in departments)
            Console.WriteLine($"- {d.Name}");
    }

    // ---------------- Task 3 ----------------
    private static async Task DemoTask3(IUserOrganizationService userOrgService, Security.Models.User user)
    {
        var chain = await OrganizationHelpers.GetUserBossChainAsync(
            userOrgService,
            user,
            includeBlocked: false
        );

        Console.WriteLine($"The chain of supervisors for: {user.fullName}");
        foreach (var item in chain)
            Console.WriteLine(item);

        Console.WriteLine("\n--- With the blocked ones ---");

        var chainWithBlocked = await OrganizationHelpers.GetUserBossChainAsync(
            userOrgService,
            user,
            includeBlocked: true
        );

        foreach (var item in chainWithBlocked)
            Console.WriteLine(item);
    }

    // ---------------- Task 4 ----------------
    private static async Task DemoTask4(IUserOrganizationService userOrgService)
    {
        var sorted = await OrganizationHelpers.SortUsersByPositionLevelAsync(
            userOrgService,
            Data.Users
        );

        Console.WriteLine("Users sorted by position level:");
        foreach (var u in sorted)
            Console.WriteLine($"{u.fullName} — post: {u.positionHash}");
    }
}
