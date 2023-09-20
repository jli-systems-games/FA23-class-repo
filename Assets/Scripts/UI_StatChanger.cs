using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_StatChanger : MonoBehaviour
{
    public Player.Stat thisStat;
    public int statValue = 10;
    public UI_CharacterCreator characterCreator;

    public TextMeshProUGUI statTMP;

    public void Start()
    {
        Player.playerStats.Add(thisStat, statValue); //add this stat to the Player Stat dictionary
        statTMP.text = Player.playerStats[thisStat].ToString();
    }

    public void ChangeStatValue(int amount)
    {
        if (characterCreator.pointsRemaining > 0)
        {
            if (statValue >= 0)
            {
                statValue += amount;
                characterCreator.AdjustPoints(amount);

                UpdatePlayerStat();
            }

        }
        else if (characterCreator.pointsRemaining == 0 && amount < 0)
        {
            statValue += amount;
            characterCreator.AdjustPoints(amount);

            UpdatePlayerStat();
        }
    }

    public void UpdatePlayerStat()
    {
        Player.playerStats[thisStat] = statValue;

    }
}
