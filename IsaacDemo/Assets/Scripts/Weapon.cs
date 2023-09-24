using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = )] 

public class Weapon : MonoBehaviour
{

    public enum weaponType
    {
        Physical,
        Magical,
    }

    public string weaponName;
    public weaponType WeaponType;
    public int weaponPower;
}
