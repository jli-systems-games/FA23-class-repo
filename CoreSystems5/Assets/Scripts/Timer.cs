using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int timeInt = 30;
    public TextMeshProUGUI timerText;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        timeInt--;
        timerText.text = timeInt.ToString();
        yield return new WaitForSeconds(1f);
        StartCoroutine(Countdown());
    }
    // Update is called once per frame
    void Update()
    {
        if(timeInt == 0){
            SceneManager.LoadScene("End");
        }
    }
}
