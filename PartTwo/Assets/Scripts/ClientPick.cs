using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientPick : MonoBehaviour
{
    public static bool krisPick;
    public static bool amberPick;
    public static bool picked;
    public GameObject SelectionScreen;

    void Start()
    {
        krisPick = false;
        amberPick = false;
        SelectionScreen.SetActive(true);
        
    }

   public void KrisPress()
    {
        krisPick = true;
        picked = true;
        SelectionScreen.SetActive(false);
        Debug.Log("Kris select" + krisPick);
        Debug.Log("Amber select" + amberPick);

    }
    public void AmberPress()
    {
        amberPick = true;
        picked = true;
        SelectionScreen.SetActive(false);
        Debug.Log("Kris select" + krisPick);
        Debug.Log("Amber select" + amberPick);
    }
}
