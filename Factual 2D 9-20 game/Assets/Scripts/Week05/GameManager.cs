using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playerName, playerWeapon, playerDex;
    void Start()
    {
        playerName.text = Player.playerName;
        playerWeapon.text = Player.playerWeapon.weaponName;
        playerDex.text = Player.playerStats[Player.Stat.Dexterity].ToString();
    }

}
