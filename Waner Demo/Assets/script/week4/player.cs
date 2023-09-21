using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class player
{
    public enum Stat
    {
        Strength,
        Dexterity,
        Constitution,
        Intellegence,
        Widsom,
        Charisma
    }

    public static Dictionary<Stat, int> playerStats = new Dictionary<Stat, int>();
    public static string playerName = "";
}
