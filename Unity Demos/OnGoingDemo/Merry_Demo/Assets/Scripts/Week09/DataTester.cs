using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTester : MonoBehaviour, IDataPersistence
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
}

