using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Xunit;

namespace WebApp;

public static class Utils
{
        //Metod 1
        public static bool IsPasswordGoodEnough(string password)
        { 
            Regex passwordCheck = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        
            return passwordCheck.IsMatch(password);
        }

/*
        //Metod 2
        public static Arr RemoveBadWordTest(string badword, string cencured)
        {

            var readBadWordsList = File.ReadAllLines(Path.Combine("json\bad-words.json"));
            Arr badWordsList = JSON.Parse(readBadWordsList);

            string cleanStrings = Regex.Replace(badword, "\\b" + string.Join("\\b|\\b", badWordsList,) +"\\b", cencured);

            return cleanStrings;
        }

    

*/


    //Metod 3
    public static Arr CreateMockUsers()
    {
        // Read all mock users from the JSON file
        var read = File.ReadAllText(FilePath("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);
        Arr successFullyWrittenUsers = Arr();
        foreach (var user in mockUsers)
        {
           // user.password = "12345678";
            var result = SQLQueryOne(
                @"INSERT INTO users(firstName,lastName,email,password)
                VALUES($firstName, $lastName, $email, $password)
            ", user);
            // If we get an error from the DB then we haven't added
            // the mock users, if not we have so add to the successful list
            if (!result.HasKey("error"))
            {
                // The specification says return the user list without password
                user.Delete("password");
                successFullyWrittenUsers.Push(user);
            }
        }
        return successFullyWrittenUsers;
    }
}


