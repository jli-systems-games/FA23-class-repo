using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//(CreateAssetMenu)
//(CreateAssetMenu(Weapon))
public class Weapon : ScriptableObject
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
