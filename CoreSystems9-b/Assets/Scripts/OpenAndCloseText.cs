using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenAndCloseText : MonoBehaviour
{
    public GameObject NPCCanvas;
    public string textToShow;
    public TextMeshProUGUI text;

    private bool toTrig = true;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(toTrig)
        {
            NPCCanvas.SetActive(true);
            text.text = textToShow;
            toTrig = false;
        }
        
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        NPCCanvas.SetActive(false);
    }
}
