using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayTime : MonoBehaviour
{
    public Timer timerScript;
    public GameObject timerHolder;

    public TextMeshProUGUI timerText;

    public int toDisplay;

    // Start is called before the first frame update
    void Start()
    {
        timerHolder = GameObject.FindGameObjectWithTag("Timer");
        timerScript = timerHolder.GetComponent<Timer>();

        toDisplay = (int)(timerScript.currentTime/60f);
        timerText.text = toDisplay.ToString();

        Debug.Log(timerScript.currentTime);
    }

}
