using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public TextMeshProUGUI score;

    void Start()
    {
        score.text = GameObject.Find("PointsController").GetComponent<PointsObject>().points.ToString();
    }
    public void OnButtonClick()
    {
        Destroy(GameObject.Find("PointsController"));
        SceneManager.LoadScene("GameScene");
    }
}
