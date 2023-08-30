using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsOpen : MonoBehaviour
{
    public GameObject settingsScreen;

    void Start()
    {
        settingsScreen.SetActive(false);
    }
    public void openSettings()
    {
        settingsScreen.SetActive(true);
    }
    public void closeSettings()
    {
        settingsScreen.SetActive(false);
    }
}
