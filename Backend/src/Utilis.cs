using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Xunit;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace WebApp;

public static class Utils
{
        //Metod 1
        public static bool IsPasswordGoodEnough(string password)
        { 
            Regex passwordCheck = new Regex("^(?=.*?[A-ZÅÄÖ])(?=.*?[a-zåäö])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        
            return passwordCheck.IsMatch(password);
        }


        //Metod 2
  public static string RemoveBadWords(string badStrings, string censored)
    {
        var badWordsFromFile = File.ReadAllText(Path.Combine("json", "bad-words.json"));
        Arr badWords = JSON.Parse(badWordsFromFile);

        string cleanStrings = Regex.Replace(badStrings, "\\b" + string.Join("\\b|\\b", badWords) + "\\b", censored, RegexOptions
        .IgnoreCase);

        return cleanStrings;
    }


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
        //Metod 4
        public static Arr RemoveMockUsers()
    {
        var read = File.ReadAllText(FilePath("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);
        Arr removedMockUsers = Arr();

        foreach (var user in mockUsers)
        {
            var result = SQLQueryOne(
                @"delete from users where firstName = $firstName and lastName = $lastName",
                user);

            if (!result.HasKey("error"))
            {
                user.Delete("password");
                removedMockUsers.Push(user);
            }
        }
        return removedMockUsers;
    }

    //Metod 5  
    public static Obj CountDomainsFromUserEmails()
    
    {
        Arr queryDomains = SQLQuery("SELECT SUBSTRING(email, instr(email, '@') + 1, length(email)) AS domain, count(id) AS count FROM users GROUP BY domain");

        Obj countedDomains = Obj();

        foreach(var domain in queryDomains)
        {
            countedDomains[domain.domain] = domain.count;
        }
        return countedDomains;
    }
}