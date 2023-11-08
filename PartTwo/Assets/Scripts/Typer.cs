using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public TextMeshProUGUI wordOutput;
    public static int count;

    private string remainingWord;
    private string typedWord;

    public string[] currentWord = new string[5];
    public float blinkTime = 1f;
    public static bool typeInput;


    public string[] convo1 = new string[3];
    public string[] convo2 = new string[4];
    public string[] convo3 = new string[3];
    public string[] convo4 = new string[3];
    public string[] convo5 = new string[3];
    public string[] convo6 = new string[3];
    public string[] convo7 = new string[3];
    public string[] convo8 = new string[3];
    public string[] convo9 = new string[4];
    public string[] convo10 = new string[3];
    public string[] badEndConvo = new string[3];
    public List<GameObject> sentDialogue;
    public List<GameObject> sentDialogueKitKat;
    public GameObject npcSpeech;
    public GameObject playerSpeech;
    public GameObject npcSpawnLocation;
    public GameObject playerSpawnLocation;

    private IEnumerator coroutine;

    public Animator flashing;
    public Animator flashingTwo;
    public Animator FadeOut;


    public GameObject kitKatTitle;
    public GameObject xyzzTitle;
    public GameObject kitKatSelect;
    public GameObject xyzzSelect;
    public Button kitKat;
    public Button xyzz;

    public bool switchedConvo;



    void Start()
    {
        count = 0;
        StartCoroutine(Conversation(convo1, convo1.Length));

        //SetCurrentWord();
        //StartCoroutine(BlinkCursor());

        kitKatTitle.SetActive(false);
        xyzzTitle.SetActive(true);
        kitKatSelect.SetActive(false);
        xyzzSelect.SetActive(true);
        switchedConvo = false;
        
        kitKat.interactable = false;
        xyzz.interactable = false;

    }
    void Update()
    {
        CheckInput();

    }



    public IEnumerator Conversation(string[] convo, int convoLength)
    {

        coroutine = Conversation(convo, convoLength);
        for (int i = 0; i < convoLength; i++)
        {
            if (switchedConvo)
            {
                break;
            }

            var temp = Instantiate(npcSpeech, npcSpawnLocation.transform);
            var text = temp.transform.GetChild(0);
            //var sizeY = temp.GetComponent<RectTransform>().sizeDelta.y;

            text.GetComponent<TextMeshProUGUI>().text = convo[i];
            //var rend= temp.GetComponent<Renderer>();
            //var moveUp = rend.bounds.size.y;
            if (count < 7 || count == 10)
            {
                foreach (GameObject sentDialogue in sentDialogue)
                {
                    sentDialogue.GetComponent<RectTransform>().transform.position += new Vector3(0, 150f, 0);
                }
                sentDialogue.Add(temp);

            }
            else if (count >= 7 && count < 10)
            {
                foreach (GameObject sentDialogueKitKat in sentDialogueKitKat)
                {
                    sentDialogueKitKat.GetComponent<RectTransform>().transform.position += new Vector3(0, 150f, 0);
                }
                sentDialogueKitKat.Add(temp);
            }

            yield return new WaitForSeconds(3);
        }
        if (convo == convo7)
        {
            FadeOut.SetTrigger("GoodEnd");
        }else if(convo == badEndConvo)
        {
            FadeOut.SetTrigger("BadEnd");
        }
        else if (convo== convo10)
        {

        }
        else
        {
            SetCurrentWord();
        }




    }

    public IEnumerator PlayerConversation()
    {

        var temp = Instantiate(playerSpeech, playerSpawnLocation.transform);
        var text = temp.transform.GetChild(0);
        //var sizeY = temp.GetComponent<RectTransform>().sizeDelta.y;
        text.GetComponent<TextMeshProUGUI>().text = typedWord;
        typedWord = "";
        //var rend= temp.GetComponent<Renderer>();
        //var moveUp = rend.bounds.size.y;

        if (count < 7 || count == 10)
        {
            foreach (GameObject sentDialogue in sentDialogue)
            {
                sentDialogue.GetComponent<RectTransform>().transform.position += new Vector3(0, 150f, 0);
            }
            sentDialogue.Add(temp);

        }
        else if (count >= 7 && count < 10)
        {
            foreach (GameObject sentDialogueKitKat in sentDialogueKitKat)
            {
                sentDialogueKitKat.GetComponent<RectTransform>().transform.position += new Vector3(0, 150f, 0);
            }
            sentDialogueKitKat.Add(temp);
        }
       


        if (count == 1)
        {
            wordOutput.text = "";
            yield return new WaitForSeconds(5);
            StartCoroutine(Conversation(convo2, convo2.Length));
        }
        if (count == 2)
        {
            wordOutput.text = "";
            yield return new WaitForSeconds(5);
            StartCoroutine(Conversation(convo3, convo3.Length));
        }
        if (count == 3)
        {
            wordOutput.text = "";
            yield return new WaitForSeconds(5);
            StartCoroutine(Conversation(convo4, convo4.Length));
        }
        if (count == 4)
        {
            wordOutput.text = "";
            yield return new WaitForSeconds(5);
            StartCoroutine(Conversation(convo5, convo5.Length));
            yield return new WaitForSeconds(10);
            flashing.SetBool("Flash", true);
            kitKat.interactable = true;

        }
        if (count == 5)
        {
            wordOutput.text = "";
            yield return new WaitForSeconds(5);
            StartCoroutine(Conversation(convo6, convo6.Length));
        }
        if (count == 6)
        {
            wordOutput.text = "";
            yield return new WaitForSeconds(5);
            StartCoroutine(Conversation(convo7, convo7.Length));
        }
        if (count == 7)
        {
            wordOutput.text = "";
            yield return new WaitForSeconds(5);
            StartCoroutine(Conversation(convo8, convo8.Length));
        }
        if (count == 8)
        {
            wordOutput.text = "";
            yield return new WaitForSeconds(5);
            StartCoroutine(Conversation(convo9, convo9.Length));
        }
        if (count == 9)
        {
            wordOutput.text = "";
            yield return new WaitForSeconds(5);
            StartCoroutine(Conversation(convo10, convo10.Length));

            yield return new WaitForSeconds(10);
            flashingTwo.SetBool("Flashing", true);
            xyzz.interactable = true;
        }

        
    }


    public void SetCurrentWord()
    {
        SetRemainingWord(currentWord[count]);
    }

    void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = "<b>" + typedWord + "</b>" + "<color=#9c72f7>" + "I" + "</color>" + "<i>" + "<color=#657f8c>" + remainingWord + "</color>" + "</i>";//Creates color difference between word already typed and not yet typed
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


                count++;
                StartCoroutine(PlayerConversation());


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

    /*IEnumerator BlinkCursor()
    {
       
            color = "<color=#9c72f7>";
            yield return new WaitForSeconds(blinkTime);
            color = "<color=#783189>";
            yield return new WaitForSeconds(blinkTime);
       
    }*/
    public void KitConvoSwitch()
    {
        switchedConvo = true;
        StopCoroutine(coroutine);
        StopCoroutine(PlayerConversation());
        typedWord = "";
        wordOutput.text = "";
        flashing.SetBool("Flash", false);
        kitKatTitle.SetActive(true);
        xyzzTitle.SetActive(false);
        kitKatSelect.SetActive(true);
        xyzzSelect.SetActive(false);
        
        typedWord = "";
        wordOutput.text = "";
        kitKat.interactable = false;

        foreach (GameObject sentDialogue in sentDialogue)
        {
            sentDialogue.SetActive(false);
        }

       
        count = 7;
        switchedConvo = false;
        StartCoroutine(Conversation(convo8, convo8.Length));




    }
    public void XyzzSwitch()
    {
        typedWord = "";
        wordOutput.text = "";
        flashingTwo.SetBool("Flashing", false);
        foreach (GameObject sentDialogueKitKat in sentDialogueKitKat)
        {
            sentDialogueKitKat.SetActive(false);
        }
        foreach (GameObject sentDialogue in sentDialogue)
        {
            sentDialogue.SetActive(true);
        }
       
        StartCoroutine(Conversation(badEndConvo, badEndConvo.Length));

        kitKatTitle.SetActive(false);
        xyzzTitle.SetActive(true);
        kitKatSelect.SetActive(false);
        xyzzSelect.SetActive(true);
        Debug.Log("badend");


    }

}

