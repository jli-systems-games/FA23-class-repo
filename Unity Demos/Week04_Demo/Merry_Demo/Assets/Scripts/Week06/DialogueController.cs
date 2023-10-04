using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class DialogueController : MonoBehaviour
{
    //dialogue canvas stuff
    public GameObject dialogueUI;
    public TextMeshProUGUI npcNameTMP;
    public TextMeshProUGUI npcDialogueTMP;

    //who is this controller attached to
    private NPC _npc;

    private int _currentDialogueInt;
    private bool _activeDialogue;

    // Start is called before the first frame update
    void Start()
    {
        _npc = GetComponent<NPCController>().npc;
        _currentDialogueInt = 0;

        _activeDialogue = false;
        dialogueUI.SetActive(false);

    }

    private void Update()
    {
        if ( _activeDialogue == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextLine();
            }
        }
    }

    public void Talk() 
    {
        if( _activeDialogue == false)
        {
            
            npcNameTMP.text = _npc.npcName;
            dialogueUI.SetActive(true);
            
            _activeDialogue = true;
            _currentDialogueInt = 0;
            NextLine();
        }
        
    }

    public void NextLine()
    {
        if(_currentDialogueInt >= _npc.dialogue.Length)
        {
            EndDialogue();
        }
        else
        {
            string currentLine = " ";

            if (_npc.dialogue[_currentDialogueInt].optional == false)
            {
                currentLine = _npc.dialogue[_currentDialogueInt]
                    .sentence;
            }
            else 
            { 
                while (_npc.dialogue[_currentDialogueInt].SayThis() 
                    == false)
                {
                    _currentDialogueInt++;
                    if (_currentDialogueInt >= _npc.dialogue.Length)
                        break;
 
                }

                if (_currentDialogueInt >= _npc.dialogue.Length)
                {
                    EndDialogue();
                    currentLine = " ";

                }
            
               else if (_npc.dialogue[_currentDialogueInt].SayThis()
                    == true)
                {
                    currentLine = _npc.dialogue[_currentDialogueInt]
                        .sentence;       
                }
            }
            _currentDialogueInt++;

            if(currentLine != " ")
            {
                npcDialogueTMP.text = currentLine;
            }

        }

  

    }

    void EndDialogue()
    {
        _activeDialogue = false;
        dialogueUI.SetActive(false);
    }


}
