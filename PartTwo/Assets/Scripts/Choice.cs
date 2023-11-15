using TMPro;
using UnityEngine;

public class Choice : MonoBehaviour
{
    public GameObject choicePanel;
    public TextMeshProUGUI option1;
    public TextMeshProUGUI option2;
    public Client amber;
    public Client kris;
    public Dialogue dialogueScript;

    public static bool choiceMade;
    public static bool betterChoice;

    public void Start()
    {
        choicePanel.SetActive(false);
        choiceMade = false;
        betterChoice = false;
    }
    public void ChoiceConvo()
    {
        if (ClientPick.amberPick)
        {
            option1.text = amber.choiceOne;
            option2.text = amber.choiceTwo;
            choicePanel.SetActive(true);

        }
        else if (ClientPick.krisPick)
        {
            option1.text = kris.choiceOne;
            option2.text = kris.choiceTwo;
            choicePanel.SetActive(true);
        }
    }

    public void ChoiceOne()
    {
        choicePanel.SetActive(false);
        Dialogue.count = 0;
        choiceMade = true;
        if (ClientPick.amberPick)
        {
            Debug.Log("AmberPick1");
            StartCoroutine(dialogueScript.Conversation(amber.firstBranch, amber.firstBranch.Length, amber.firstBranchResponses));
        }
        else if (ClientPick.krisPick)
        {
            StartCoroutine(dialogueScript.Conversation(kris.firstBranch, kris.firstBranch.Length, kris.firstBranchResponses));
        }
        
    }
    public void ChoiceTwo()
    {
        choicePanel.SetActive(false);
        Dialogue.count = 0;
        choiceMade = true;
        betterChoice = true;
        if (ClientPick.amberPick)
        {
            Debug.Log("AmberPick2");
            StartCoroutine(dialogueScript.Conversation(amber.secondBranch, amber.secondBranch.Length, amber.secondBranchResponses));
        }
        else if (ClientPick.krisPick)
        {
            StartCoroutine(dialogueScript.Conversation(kris.secondBranch, kris.secondBranch.Length, kris.secondBranchResponses));
        }

    }
}
