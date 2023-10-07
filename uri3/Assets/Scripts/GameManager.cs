using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<Cup> cups = new List<Cup>();
    public GameObject winText; 

    void Start()
    {

        Cup[] foundCups = FindObjectsOfType<Cup>();
        cups.AddRange(foundCups);

        
        if (winText != null)
        {
            winText.SetActive(false);
        }
    }

    void Update()
    {
        if (AllCupsFilled())
        {
            
            if (winText != null)
            {
                winText.SetActive(true); 
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            ReloadScene();
        }
    }

    bool AllCupsFilled()
    {
        foreach (Cup cup in cups)
        {
            if (!cup.IsFilled())
            {
                return false; 
            }
        }
        return true; 
    }

    void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
