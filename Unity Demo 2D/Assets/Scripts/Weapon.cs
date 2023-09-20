using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
   
    public enum WeaponStats
    {
        Physical,
        Magic
    }
    public string weaponName;
    public WeaponStats weaponStats;

    public int weaponPower;
}
