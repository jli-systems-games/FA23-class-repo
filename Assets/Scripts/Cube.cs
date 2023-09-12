using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{
    public DroppingCube droppingCube;
    public PointsObject pointsObject;
    public CamMovement camControl;

    private bool isTriggered = false;
    
    void OnCollisionEnter(Collision collision)
    {
        //Might still be able to fall off balance
        if (collision.gameObject.tag == "Base")
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("GameOver");
        }
        
        //If we're already spent, we leave
        if (isTriggered)
        {
            return;
        }
        
        //successful landing
        if (collision.gameObject.tag == "Building")
        {
            Debug.Log("Collision with building");
            isTriggered = true;
            droppingCube.CreateCube();
            pointsObject.IncrementScore();
            camControl.MoveCamera();
            gameObject.tag = "Building"; //create new platform
            collision.gameObject.tag = "Untagged";  //clear tag to avoid unlimited collisions
        }


    }
}
