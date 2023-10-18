using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeNumber : MonoBehaviour
{
    public GameObject spot2;
    public GameObject spot3;
    public GameObject spot4;
    public GameObject spot5;

    public GameObject de2;
    public GameObject de3;
    public GameObject de4;
    public GameObject de5;


    public static int counter = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        counter++;
        if (counter == 1)
        {
            spot2.SetActive(true);
            de2.SetActive(false);
        }
        else if (counter == 2)
        {
            spot3.SetActive(true);
            de3.SetActive(false);
        }
        else if (counter == 3)
        {
            spot4.SetActive(true);
            de4.SetActive(false);
        }
        else if (counter == 4)
        {
            SceneManager.LoadScene("end");
            spot5.SetActive(true);
            de5.SetActive(false);
        }
        Debug.Log(counter);
        collision.enabled = false;
    }
}
