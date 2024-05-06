using Xunit;
namespace WebApp;
public class UtilsTest
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



    //Metod 3
    /*[Fact]
    public void TestCreateMockUsers(){
       var read = File.ReadAllText(Path.Combine("json/mock-users.json"));  
       Arr mockUsers = JSON.Parse(read);
       Arr usersInDB = SQLQuery("SELECT * FROM users");
    
       Arr emailsInDB = usersInDB.Map(user => user.email);
       Log(emailsInDB);

       Arr mockUserNotInDB = mockUsers.Filter(mockUser => !emailsInDB.Contains(mockUser.email));
       foreach(var user in mockUserNotInDB){
        Log(user);
       }
       Log("mockUserNotInDB.Length", mockUserNotInDB.Length );


    var result = Utils.CreateMockUsers();
    //Console.WriteLine("TEST:", mockUserNotInDB);
    //Console.WriteLine("METHOD:", result);
    //Assert the same length
    Assert.Equal(mockUserNotInDB.Length, result.Length);

    //Check equivalency for each user
    for (int i = 0; i < result.Length; i++){
    //Assert.Equivalent(mockUserNotInDB[i], result[i]);

   //Console.WriteLine("result[i]", result[i]);
   //Console.WriteLine("mockUsersNotInDB[i]", result[i]);
    }

       //Assert.Equivalent(mockUserNotInDB, Utils.CreateMockUsers());

      /* foreach(var user in usersInDB)
       
        mockUsers = mockUsers.Filter(mockUser => mockUser.email != user.email);
    */




    //Metod 4



    //Metod 5

}