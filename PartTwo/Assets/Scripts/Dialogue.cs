using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public static int count;


    public static IEnumerator coroutine;


    public List<GameObject> sentDialogue;
    public static string[] currentResponses;
    public static string[] currentConvo;
    public GameObject npcSpeech; //the speech bubbles
    public GameObject playerSpeech;
    public GameObject npcSpawnLocation;
    public GameObject playerSpawnLocation;
    public TextMeshProUGUI endingtext;

    public Typer typerScript;
    public Choice choiceScript;
    public PageSetup pageSetupScript;

    public Animator fade;



    public void Update()
    {
        if (ClientPick.picked)
        {

            currentResponses = PageSetup.picked.initialResponses;
            currentConvo = PageSetup.picked.initialConvo;
            StartCoroutine(Conversation(currentConvo, currentConvo.Length, currentResponses));
            ClientPick.picked = false;
        }
    }

    public IEnumerator Conversation(string[] convo, int convoLength, string[] response) //Start Responses
    {
        currentResponses = response;
        coroutine = Conversation(convo, convoLength, response);
        currentConvo = convo;

        for (int i = count; i < convoLength; i++)
        {
            //i = count;
            if (convo[i] != "")
            {
                yield return new WaitForSeconds(3);

                var temp = Instantiate(npcSpeech, npcSpawnLocation.transform);
                var text = temp.transform.GetChild(0);


                text.GetComponent<TextMeshProUGUI>().text = convo[i];


                foreach (GameObject sentDialogue in sentDialogue)
                {
                    sentDialogue.GetComponent<RectTransform>().transform.position += new Vector3(0, 100f, 0);
                }
                sentDialogue.Add(temp);
                count++;
            }
            else
            {
                yield return new WaitForSeconds(0.5f);

                typerScript.SetCurrentWord();
                break;
            }


        }
        if (count == convoLength && Choice.choiceMade == false)
        {
            choiceScript.ChoiceConvo();
        }
        else if (count == convoLength && Choice.choiceMade == true)
        {
            if (Choice.betterChoice && ClientPick.amberPick)
            {
                pageSetupScript.feeling.text = "<color=#66ff99>Hopeful</color>";
            }
            else if (Choice.betterChoice && ClientPick.krisPick)
            {
                pageSetupScript.feeling.text = "<color=#66ff99>Sad</color>";
            }

            yield return new WaitForSeconds(3);
            foreach (GameObject sentDialogue in sentDialogue)
            {
                sentDialogue.GetComponent<RectTransform>().transform.position += new Vector3(0, 50f, 0);
            }
            endingtext.text = "-" + pageSetupScript.nameText.text.ToString() + " has left the chat-";
            yield return new WaitForSeconds(3);
            fade.SetTrigger("End");

        }


    }




    public IEnumerator PlayerConversation()
    {

        foreach (GameObject sentDialogue in sentDialogue)
        {
            sentDialogue.GetComponent<RectTransform>().transform.position += new Vector3(0, 100f, 0);
        }
        var temp = Instantiate(playerSpeech, playerSpawnLocation.transform);
        var text = temp.transform.GetChild(0);
        text.GetComponent<TextMeshProUGUI>().text = Typer.typedWord;
        Typer.typedWord = "";
        sentDialogue.Add(temp);
        typerScript.wordOutput.text = "";
        yield return new WaitForSeconds(1);

        StartCoroutine(Conversation(currentConvo, currentConvo.Length, currentResponses));

    }


}

