using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    //public int points;
    public  TextMeshProUGUI score;
    PersistPoints pp;
    public GameObject persist;
    private void Start()
    {
        GameObject textbox = GameObject.Find("Score");
        GameObject persist = GameObject.Find("Persist");
        pp = persist.GetComponent<PersistPoints>();
        var final = PersistPoints.points;
        score.text = final.ToString();
        PersistPoints.points = 0;
        Destroy(persist);
    }
    public void OnButtonClick()
    {
       
        SceneManager.LoadScene("GameScene");
        
    }
}
