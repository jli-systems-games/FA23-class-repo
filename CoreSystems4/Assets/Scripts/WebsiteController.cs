using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebsiteController : MonoBehaviour
{
    public GameObject[] UIIcons;


    public void activateUI()
    {
        for (int i = 0;i<=UIIcons.Length;i++)
        {
            UIIcons[i].SetActive(true);
        }
        Debug.Log("sdf");
    }
}
