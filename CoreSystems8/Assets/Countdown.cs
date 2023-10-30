using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Countdown : MonoBehaviour
{
    public float timeLeft;
    public TextMeshProUGUI text;
    public SceneController scScript;
    
    // Start is called before the first frame update
    void Start()
    {
        scScript = this.GetComponent<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            updateTimer(timeLeft);
        }

        else
        {
            SceneManager.LoadScene("end Scene");
            timeLeft = 0;
        }
    }

    public void updateTimer(float currentTime)
    {
        currentTime +=1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        text.text = minutes + ":" + seconds;
    }

    public void SubtractTime()
    {
        timeLeft -= 5f;
        updateTimer(timeLeft);
    }

    public void AddTime(float val)
    {
        timeLeft += val;
    }
}
