using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectAct : MonoBehaviour
{
    public GameObject Save;
    public bool ifact;


    void Start()
    {

        if(GameObject.activeSelf){

            ifact = true;
        }
        else{
            ifact = false;
        }
        if(GameObject.activeSelf){
            PlayerPrefs.SetString("SelectedObj", "A");
            PlayerPrefs.Save();
        }
    }
}
