using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject hairSprite;
    public GameObject shirtSprite;

    public GameObject finalSprite;

    void Start()
    {
        
    }

    void whatEver()
    {
        string selectedHair = PlayerPrefs.GetString("SelectedHair");
        string selectedShirt = PlayerPrefs.GetString("SelectedShirt");

        if (selectedHair == "HairA")
        {
            
        }

        else if (selectedHair == "HairB")
        {

        }

        if (selectedShirt == "ShirtA")
        {

        }
        else if (selectedShirt == "ShirtB")
        {

        }
    }
}
