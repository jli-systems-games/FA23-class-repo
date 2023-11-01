using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTester : MonoBehaviour, IDataPersistence //it will be mad at you until you impliment the functions!
{
    public int health;

    public void LoadData(Data data)
    {
        this.health = data.health;
    }

    public void SaveData(ref Data data)
    {
        data.health = this.health;
    }

    public void IncreaseHealth()
    {
        health++;
    }
}
