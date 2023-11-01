using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistence 
{
    //interfaces basically are templetes. when another script "impliments" and inferface, 
    //it HAS to have the functions theinterface has

    //what these functions do is up to you, they just need to all be there and take the same inputs

    void LoadData(Data data);
    void SaveData(ref Data data); //we do ref so that the implementing script can modify the data   

}
