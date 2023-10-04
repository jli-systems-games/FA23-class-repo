using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playerName, playerWeapon, playerDex;

    private void Start()
    {
        playerName.text = Player.playerName;
        playerWeapon.text = Player.playerWeapon.weaponName;

        playerDex.text = Player.playerStats[Player.Stat.Dexterity].ToString();

    }
}
