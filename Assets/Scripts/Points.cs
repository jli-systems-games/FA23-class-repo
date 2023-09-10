using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int points;
    public GameObject spawner;
    public GameObject block;
    public TextMeshProUGUI score;
    public Camera cam;
    public Canvas Canvas;

    DroppingCube droppingCube;
    private void Start()
    {
        GameObject textbox = GameObject.Find("Score");
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        score = textbox.GetComponent<TextMeshProUGUI>();
        droppingCube = spawner.GetComponent<DroppingCube>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Building")
        {
            points++;
            score.text = points.ToString();
            if (spawner.transform.childCount<1) { 
            var newBlock=Instantiate(block, spawner.transform.position, Quaternion.identity);
                var fall = newBlock.GetComponent<Rigidbody>();
                
                fall.useGravity = false;
                newBlock.transform.parent = spawner.transform;
            }
        }
        if (collision.gameObject.tag == "Base")
        {
            Debug.Log("GameOver");
        }

    }
}
