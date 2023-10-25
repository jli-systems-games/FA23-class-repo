using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponRandomizer : MonoBehaviour
{
    public TextMeshProUGUI btnText;
    private Weapon _weapon;
    // Start is called before the first frame update
    void Start()
    {
        //randomly assign a weapon
        _weapon = GameData.weaponDatabase[Random.Range
            (0, GameData.weaponDatabase.Count)];
        btnText.text = _weapon.weaponName;
    }

    public void GiveWeapon()
    {
        Player.playerWeapon = _weapon;
    }

}
