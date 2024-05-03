using Xunit;
namespace WebApp;
public class UtilsTest
{
    /*[Fact]
    public void TestSumInt()
    {
        Assert.Equal(12, Utils.SumInts(7, 5));
        Assert.Equal(-3, Utils.SumInts(6, -9));

    }*/

[Fact]
[Theory]
public void IsPasswordGoodEnoughTest()
{
    string badPassword = "psw123"; 
    string goodPassword = "Psw12345!";

    bool isBadPasswordGoodEnough = Utils.IsPasswordGoodEnough(badPassword);
    bool isGoodPasswordGoodEnough = Utils.IsPasswordGoodEnough(goodPassword);

    Assert.False(isBadPasswordGoodEnough);
    Assert.True(isGoodPasswordGoodEnough);
}

}

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

