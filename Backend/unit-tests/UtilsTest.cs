using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApp;
public class UtilsTest(Xlog Console)
{
    //Metod 1
    [Theory]
    [InlineData("psw123", false)] // Bad password
    [InlineData("Psw12345!", true)] // Good password
    [InlineData("TestaÅäÖ123!", true)]
    public void IsPasswordGoodEnoughTest(string password, bool expectedResult)
    {
        bool result = Utils.IsPasswordGoodEnough(password);
        Assert.Equal(expectedResult, result);
    }

    //Metod 2
    [Theory]
    [InlineData("shit happens", "****", "**** happens")]
    [InlineData("angel ass", "****", "angel ****")]

    public void TestRemoveBadWords(string badStrings, string censored, string cleanStrings)
    {
        Assert.Equal(cleanStrings, Utils.RemoveBadWords(badStrings, censored));
    }

    [Fact]
    public void TestCreateMockUsers()
    {
        // Read all mock users from the JSON file
        var read = File.ReadAllText(FilePath("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);
        // Get all users from the database
        Arr usersInDb = SQLQuery("SELECT email FROM users");
        Arr emailsInDb = usersInDb.Map(user => user.email);
        // Only keep the mock users not already in db
        Arr mockUsersNotInDb = mockUsers.Filter(
            mockUser => !emailsInDb.Contains(mockUser.email)
        );
        // Get the result of running the method in our code
        var result = Utils.CreateMockUsers();
        // Assert that the CreateMockUsers only return
        // newly created users in the db
        Console.WriteLine($"The test expected that {mockUsersNotInDb.Length} users should be added.");
        Console.WriteLine($"And {result.Length} users were added.");
        Console.WriteLine("The test also asserts that the users added " +
            "are equivalent (the same) to the expected users!");
        Assert.Equivalent(mockUsersNotInDb, result);
        Console.WriteLine("The test passed!");
    }

  //Metod 4
    [Fact]
    public void TestRemoveMockUsers()
    {
        var read = File.ReadAllText(FilePath("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);
        var removedMockUsers = Utils.RemoveMockUsers();

        Arr removedMockUserEmails = removedMockUsers.Map(user => user.email);

        Arr remainingUsersInDb = SQLQuery("select email from users");

        foreach (var user in removedMockUsers)
        {
            Assert.DoesNotContain(user.email, remainingUsersInDb.Map(u => u.email));
        }
        
        Assert.Equivalent(mockUsers, removedMockUsers);

        Console.WriteLine($"{removedMockUsers.Length} mock users removed from db");
        Console.WriteLine("test passed");

        Utils.CreateMockUsers();
    }
    //Metod 5




}
