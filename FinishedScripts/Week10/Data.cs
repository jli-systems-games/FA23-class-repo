using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data 
{
    public int health;

    //this is called a constructor - basically it initiallizes values in a class that doesn't have stuff like Start
    //this will initialize values for use when there is no data to load
    public Data()
    {
        this.health = 0; //what does "this" mean? - this refers to this script, not the game object. because this is not a 
                             //monobehaviour, we need to access THIS script directly.
    }
}
