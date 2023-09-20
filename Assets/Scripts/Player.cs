using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Player
{
    //info that can be grabbed by any script
    public enum Stat
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }

    public static Dictionary<Stat, int> playerStats = new Dictionary<Stat, int>();
    public static string playerName = " ";
    public static Weapon playerWeapon = null;
}
