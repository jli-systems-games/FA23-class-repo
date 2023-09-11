using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistPoints : MonoBehaviour
{
    public static int points;
    public TextMeshProUGUI score;
    public Canvas Canvas;
    public Scene currentScene;
    Points pointsScript;
    



    void Start()
{
    DontDestroyOnLoad(this.gameObject);
     currentScene = SceneManager.GetActiveScene();
        points = 0;




    }


public void Persistance()
{
        if (currentScene.name == "GameScene")
        {

            GameObject pointObject = GameObject.Find("BuildingPiece");
            pointsScript = pointObject.GetComponent<Points>();
            points=pointsScript.points;
            Debug.Log(points);

        }
    }
        
}
