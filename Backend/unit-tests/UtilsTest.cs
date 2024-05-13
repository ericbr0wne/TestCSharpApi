namespace WebApp;
public class UtilsTest(Xlog Console)
{


    //Metod 1
    [Theory]
    [InlineData("psw123", false)] // Bad password
    [InlineData("Psw12345!", true)] // Good password
    public void IsPasswordGoodEnoughTest(string password, bool expectedResult)
    {
        bool result = Utils.IsPasswordGoodEnough(password);

        Assert.Equal(expectedResult, result);
    
    }


    //Metod 2
    /*
    [Theory]
    [InlineData("shit", false, "****")] //bad word
    [InlineData("angel", true, "****")] //good word
    [InlineData("Hell", false, "****")] //bad word
    [InlineData("Hello", true, "****")] //good word

    public void RemoveBadWordTest(string badword, bool expectedResult, string cencured)
    {


        return 
    }

  */



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



    //Metod 5


}  