using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_StatChanger : MonoBehaviour
{
    public Player.Stat thisStat;
    public int statValue = 10;

    public TextMeshProUGUI statTMP;
    public UI_CharacterCreator characterCreator;

    public void Start()
    {
        Player.playerStats.Add(thisStat, statValue); //add this stat to the player stat dict
        statTMP.text = Player.playerStats[thisStat].ToString(); //display the current stat
    }


    public void ChangeStatValue(int amount)
    {
        if (characterCreator.pointsRemaining > 0)
        {

            if (statValue >= 0)
            {
                statValue += amount;
                characterCreator.AdjustPoints(amount);

                UpdatePlayerStats();
            }
        }
        else if (characterCreator.pointsRemaining == 0 && amount < 0)
        {
            statValue += amount;
            characterCreator.AdjustPoints(amount);

            UpdatePlayerStats();
        }
    }

    public void UpdatePlayerStats()
    {
        Player.playerStats[thisStat] = statValue;
        statTMP.text = Player.playerStats[thisStat].ToString(); //display the current stat

    }
}
