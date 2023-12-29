using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static PointsManager;


public class Typer : MonoBehaviour
{
    public TextMeshProUGUI wordOutput; 
    public TextMeshProUGUI timer;
    public TextMeshProUGUI score;
    public GameObject spawner;
    PopUpSpawner popUpSpawner;

    private string remainingWord;
    private string typedWord;
    public string currentWord = "Hi Moth, I swear I can type fast. Watch! Check it out I'm in the house like carpet. And if there's too many heads in my blunt I won't spark it I'll put it in my pocket and save it like rocket fuel 'til everybody's gone and it's cool. Then I spark it up with my brother. His momma named him Mo, but I call him Mo' Lover. And he's more than a cover, he's a quilt. We're putting shit together like that house that John built on the hill, 'cause this shit's gonna feel like velvet, turtle. My style fits tighter than a girdle. If ya hate it then you can just leavе it, like Beaver. But in a day or two I'll makе you a true believer in me, 'cause like the alphabet you'll see, that 'ism kicks a rhyme, not your everyday soliloquy. Like Chef Boyardee, my rhyme is truly cookin'. Peace to Matty Rich 'cause he's straight out of Brooklyn, New York. I don't eat pork or swine when I dine. I drink a cup of Kool-Aid, not a big glass of wine, or a Heineken, if you have time I'll drop rhyme again.";
    public float timeRemaining = 180;

    void Start()
    {
        SetCurrentWord();
        spawner = GameObject.Find("PopUpSpawner"); //Gets spawner so we can check if popups are on screen
        popUpSpawner = spawner.GetComponent<PopUpSpawner>();
        currentScore = 0;
        
    }

    void SetCurrentWord()
    {
        SetRemainingWord(currentWord);
    }

    void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = "<b>" + typedWord + "</b>" + "<i>"+"<color=#657f8c>" + remainingWord + "</color>"+"</i>";//Creates color difference between word already typed and not yet typed
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();

        if (timeRemaining > 0) //counts down and desplays timer
        {
            timeRemaining -= (Time.deltaTime);
            float seconds = Mathf.FloorToInt(timeRemaining);
            timer.text = seconds.ToString();
        }
        else if(timeRemaining <= 0 && !IsComplete()) //Run out of time
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("BadEnd");
        }

        score.text = currentScore.ToString();

    }


    void CheckInput()
    {
        if (popUpSpawner.currentPopups == 0) //Only allows typing when no pop ups are on screen
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
        else
        {
            Debug.Log("popup active");
        }


    }

    void EnterLetter(string typedLetter)
    {
        if (IsCorrectLetter(typedLetter))
        {
            RemoveLetter();
            currentScore += 100; //add 100

            if (IsComplete()) //checks if player has completed the typed sentances
            {
                Debug.Log("Done");
                SceneManager.LoadScene("GoodEnd");

            }
        }
        else
        {
            currentScore -= 100; //subtract 100
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
