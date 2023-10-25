using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponRandomizer : MonoBehaviour
{
    public TextMeshProUGUI btnText;
    private Weapon _weapon;

    private void Start()
    {
        _weapon = GameData.weaponDatabase[Random.Range(0, GameData.weaponDatabase.Count)];

        //btnText;
    }

    public void GiveWeapon()
    {
        Player.playerWeapon = _weapon;
    }
}
