using UnityEngine;

public class Pancake : MonoBehaviour
{
    public int scoreValue = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plate")) 
        {
            ScoreManager.Instance.AddPoints(scoreValue); 
        }
        else
        {
            ScoreManager.Instance.SubtractPoints(scoreValue); 
        }

    }
}
