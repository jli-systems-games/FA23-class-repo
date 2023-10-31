using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenNPCText : MonoBehaviour
{
    public GameObject NPCCanvas;
    public string textToShow;
    public TextMeshProUGUI text;

    void OnTriggerEnter2D(Collider2D collider)
    {
        NPCCanvas.SetActive(true);
        text.text = textToShow;
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        NPCCanvas.SetActive(false);
    }
}