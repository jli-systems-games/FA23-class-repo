using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_CharacterCreator : MonoBehaviour
{
    //UI refs
    public int pointsRemaining;
    public TextMeshProUGUI pointsRemainingTMP;
    public TMP_Dropdown weaponDropdown;
    public GameObject weaponError;
    public Button btn_startGame;


    //Weapon Setup
    public Weapon[] startWeapons = new Weapon[0];
    public Weapon selectedWeapon = null;

    private bool _weaponCheck;

    private void Start()
    {
        pointsRemainingTMP.text = pointsRemaining.ToString();

        _weaponCheck = true;
        weaponError.SetActive(false);
        btn_startGame.interactable = false;

        Player.playerWeapon = startWeapons[0];
        selectedWeapon = startWeapons[0];
    }

    public void CheckWeapon()
    {
        string currentWeapon = weaponDropdown.options[weaponDropdown.value].text.ToString();
        _weaponCheck = true;
        weaponError.SetActive(false);

        foreach (Weapon weapon in startWeapons) //for (int i= 0, i< startWeapon.length
        {
            if (weapon.weaponName == currentWeapon)
            {
                selectedWeapon = weapon;
                break;
            }
        }

        if (Player.playerStats[Player.Stat.Strength] < selectedWeapon.reqStr)
            _weaponCheck = false;
        if (Player.playerStats[Player.Stat.Dexterity] < selectedWeapon.reqDex)
            _weaponCheck = false;
        if (Player.playerStats[Player.Stat.Constitution] < selectedWeapon.reqCon)
            _weaponCheck = false;
        if (Player.playerStats[Player.Stat.Intelligence] < selectedWeapon.reqInt)
            _weaponCheck = false;
        if (Player.playerStats[Player.Stat.Wisdom] < selectedWeapon.reqWis)
            _weaponCheck = false;
        if (Player.playerStats[Player.Stat.Charisma] < selectedWeapon.reqCha)
            _weaponCheck = false;

        if (_weaponCheck == false)
        {
            weaponError.SetActive(true);
            btn_startGame.interactable = false;
        }

    }

    public void AdjustPoints(int point)
    {
        pointsRemaining -= point;
        pointsRemainingTMP.text = pointsRemaining.ToString();

    }

}
