using System.Collections.Generic;
using Newtonsoft.Json;

namespace Race;

internal class UserStorage
{
    private static string Path = "RaceUserResults.json";

    public static void SaveUserResult(User user)
    {
        var usersResults = GetUserResults();
        usersResults.Add(user);
        Save(usersResults);
    }

    public static List<User> GetUserResults()
    {
        if (!FileProvider.Exists(Path))
        {
            return new List<User>();
        }
        var fileData = FileProvider.GetValue(Path);
        var userResult = JsonConvert.DeserializeObject<List<User>>(fileData);
        return userResult;
    }

    static void Save(List<User> UserResult)
    {
        var jsonData = JsonConvert.SerializeObject(UserResult, Formatting.Indented);
        FileProvider.Replace(Path, jsonData);
    }
}
