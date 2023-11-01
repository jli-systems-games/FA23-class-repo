using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI_CharacterCreator : MonoBehaviour
{
    //UI References
    public int pointsRemaining;
    public TextMeshProUGUI pointsRemainingTMP;
    public TMP_Dropdown weaponDropdown;
    public GameObject weaponError;
    public Button btn_startGame;
    public TMP_InputField nameIF;

    //Weapon Setup
    public Weapon[] startWeapons = new Weapon[0];
    public Weapon selectedWeapon = null;

    private bool _weaponCheck;

    // Start is called before the first frame update
    void Start()
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

        foreach (Weapon weapon in startWeapons) //for (int i= 0; i< startWeapons.length
        {
            if(weapon.weaponName == currentWeapon)
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
            weaponError.SetActive (true);
            btn_startGame.interactable = false;
        }


    }

    public void AdjustPoints(int point)
    {
        pointsRemaining -= point;
        pointsRemainingTMP.text = pointsRemaining.ToString();

        CheckStart();
    }

    public void CheckStart()
    {
        if (_weaponCheck == true)
        {
            if(pointsRemaining == 0)
            {
                if(nameIF.text != "")
                {
                    //Debug.Log(nameIF.text);
                    btn_startGame.interactable = true;
                }
                else
                    btn_startGame.interactable = false;
            }
            else
                btn_startGame.interactable = false;
        }
        else
            btn_startGame.interactable = false;
    }
    public void StartGame(string nextScene)
    {
        if (Player.playerWeapon == null)
            Player.playerWeapon = startWeapons[0];
        else
            Player.playerWeapon = selectedWeapon;

        Player.playerName = nameIF.text;

        //scene change
        SceneManager.LoadScene(nextScene);

    }
}
