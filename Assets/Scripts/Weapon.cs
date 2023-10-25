using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "ScriptableObjects/Weapon", order = 1)]

public class Weapon : ScriptableObject
{
    public int weaponID;

    public enum WeaponType
    {
        Physical,
        Magic
    }

    public string weaponName;
    public WeaponType weaponType;
    public int weaponPower;

    public int reqStr = 0;
    public int reqDex = 0;
    public int reqCon = 0;
    public int reqInt = 0;
    public int reqWis = 0;
    public int reqCha = 0;


}
