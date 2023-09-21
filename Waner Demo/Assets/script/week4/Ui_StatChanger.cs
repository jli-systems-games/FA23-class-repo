using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ui_StatChanger : MonoBehaviour
{
    public player.Stat thisStat;
    public int statValue = 10;

    public TextMeshProUGUI statTMP;
    public charactorCreator charactor;
    public TMP_Dropdown weaponDropdown;

    //weapon setup
    public Weapons[] statWeapons = new Weapons[0];
    public Weapons selectedWeapon = null;



    public void Start()
    {
        player.playerStats.Add(thisStat, statValue);
        statTMP.text = player.playerStats[thisStat].ToString();
    }

    public void ChangeStatValue(int amount)
    {
        if (charactor.pointsRemaining > 0)
        {

        
        if (statValue >= 0)
        {
            statValue += amount;
            UpdatePlayerStat();

            charactor.AdjustPoints(amount);
        }
    }
        else if (charactor.pointsRemaining == 0 && amount<0)
        {
            statValue += amount;
            UpdatePlayerStat();

            charactor.AdjustPoints(amount);
        }
}

    public void UpdatePlayerStat()
    {
        player.playerStats[thisStat] = statValue;
        statTMP.text = player.playerStats[thisStat].ToString();
    }
}
