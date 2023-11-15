using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public TextMeshProUGUI wordOutput;
    
    private string remainingWord;
    public static string typedWord;

    
    public float blinkTime = 1f;
    public static bool typeInput;

    public Dialogue dialogueScript;

    void Start()
    {
       // Dialogue.count = 0;
     
    }
    void Update()
    {
        CheckInput();
        //currentWord = Dialogue.currentResponses;
    }

    public void SetCurrentWord()
    {
        SetRemainingWord(Dialogue.currentResponses[Dialogue.count]);
    }

    void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = "<b>" + typedWord + "</b>" + "<color=#9c72f7>" + "I" + "</color>"  + "<color=#657f8c>" + remainingWord + "</color>";//Creates color difference between word already typed and not yet typed
    }




    void CheckInput()
    {

        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;
            if (keysPressed.Length == 1)
            {
                EnterLetter(keysPressed); //detects letter press
            }
        }

    }

    void EnterLetter(string typedLetter)
    {
        if (IsCorrectLetter(typedLetter))
        {
            RemoveLetter();

            if (IsComplete()) //checks if player has completed the typed sentances
            {
                Debug.Log("Ready");


                Dialogue.count++;
                StartCoroutine(dialogueScript.PlayerConversation());


                //SetCurrentWord();


            }
        }

    }
    bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0; //checks if letter is correct
    }
    void RemoveLetter()
    {
        char temp = remainingWord[0];
        string newString = remainingWord.Remove(0, 1);
        typedWord += temp;
        SetRemainingWord(newString);
    }

    bool IsComplete()
    {
        return remainingWord.Length == 0;
    }



}

