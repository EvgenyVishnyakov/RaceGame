using System;

namespace Race;

public class User
{
    public string Name;
    public string score;
    public int AmountOfCoins = 0;
    public string DateOfgame;

    public User(string name)
    {
        Name = name;
    }

    public string GetScores(string AmountOfScore)
    {
        return score = "" + AmountOfScore;
    }

    public void GetCoins()
    {
        AmountOfCoins++;
    }

    public void GetDate()
    {
        DateOfgame = DateTime.Now.ToString();
    }
}