using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float secondsCount;
    private int minuteCount;
    public static float count;


    private void Start()
    {
        DontDestroyOnLoad(this);
      
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            UpdateTimerUI();
        }
        if (SceneManager.GetActiveScene().name == "EndScreen")
        {
            Debug.Log("Working");
            var text = GameObject.Find("Score");
            timerText = text.GetComponent<TextMeshProUGUI>();
            timerText.text = minuteCount + ":" + ((int)secondsCount).ToString("00");
        }

    }

    //call this on update
    public void UpdateTimerUI()
    {
        
        
        //set timer UI
        secondsCount += Time.deltaTime;
        count += Time.deltaTime;
        timerText.text = minuteCount + ":" + ((int)secondsCount).ToString("00");
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
       
    }
}
