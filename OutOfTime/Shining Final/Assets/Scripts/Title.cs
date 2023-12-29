using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    public GameObject extra1;
    public GameObject extra2;
    public GameObject extra3;
    public GameObject extra4;
    public GameObject extra5;
    public GameObject extra6;
    public GameObject extra7;
    public GameObject extra8;

    public void StartGame()
    {
        extra1.SetActive(true);
        extra2.SetActive(true);
        extra3.SetActive(true);
        extra4.SetActive(true);
        extra5.SetActive(true);
        extra6.SetActive(true);
        extra7.SetActive(true);
        extra8.SetActive(true);
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }
}
