using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Minigame : MonoBehaviour
{
    public GameObject minigame;
    public GameObject moving;
    public bool gameStart = false;
    public bool movingLeft = true;
    public float speed;
    public int choiceCount=0;
    public bool pos;
    public DialogueRunner dialogueRunner;
    public string convoNode;

    public void Start()
    {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
    }

    public void Update()
    {
        if (gameStart)
        {
            if (movingLeft == true)
            {
                Debug.Log("moving");
                moving.transform.Translate(Vector3.left * speed * Time.deltaTime);
                if (moving.transform.localPosition.x <= -300) movingLeft = false;
            }
            else
            {
                moving.transform.Translate(Vector3.right * speed * Time.deltaTime);
                if (moving.transform.localPosition.x >= 300) movingLeft = true;
            }

            if (Input.GetMouseButtonDown(0))
            {
                ChoiceMade();
            }
                


        }
    }

    [YarnCommand("minigame")]
    public void ChoiceGame()
    {
        minigame.GetComponent<Canvas>().enabled = true;
        gameStart = true;


    }

    public void ChoiceMade()
    {
        if (moving.transform.localPosition.x < 0)
        {
            pos = false;
        }else if (moving.transform.localPosition.x >= 0)
        {
            pos = true;
        }
        minigame.GetComponent<Canvas>().enabled = false;
        gameStart = false;

        if (pos && choiceCount == 0)
        {
            
            convoNode = "PositiveOne";
            
        }
        if (!pos && choiceCount == 0)
        {

            convoNode = "NegativeOne";
           
        }
        if (pos && choiceCount == 1)
        {

            convoNode = "PositiveTwo";
            
        }
        if (!pos && choiceCount == 1)
        {

            convoNode = "NegativeTwo";
           
        }
        if (pos && choiceCount == 2)
        {

            convoNode = "Acceptance";
           
        }
        if (!pos && choiceCount == 2)
        {

            convoNode = "Rejection";
           
        }

        dialogueRunner.StartDialogue(convoNode);
        choiceCount++;
        speed *= 2;


    }




}
