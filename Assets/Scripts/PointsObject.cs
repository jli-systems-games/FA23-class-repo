using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointsObject : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI score;
    
    void Start()
    {
        points = 0;
        DontDestroyOnLoad(this);
    }

    public void IncrementScore()
    {
        points++;;
        score.text = points.ToString();
    }
        
}
