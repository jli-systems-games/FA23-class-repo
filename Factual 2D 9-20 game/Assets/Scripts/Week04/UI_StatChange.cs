using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_StatChange : MonoBehaviour
{
    public Player.Stat thisStat;
    public int statValue = 10;

    public TextMeshProUGUI statTMP;
    public UI_CharacterCreator characterCreator;

    //public TextMeshProUGUI statText;

    public void Start()
    {
        Player.playerStats.Add(thisStat, statValue); //Add this stat to the Player Stat dictionary
        statTMP.text = Player.playerStats[thisStat].ToString(); //Display what the current stat
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
            if (statValue >= 0)
            {
                statValue += amount;
                characterCreator.AdjustPoints(amount);

                UpdatePlayerStats();
            }

        }
    }
        public void UpdatePlayerStats()
        {
            Player.playerStats[thisStat] = statValue;
            statTMP.text = Player.playerStats[thisStat].ToString();
        }
    }
