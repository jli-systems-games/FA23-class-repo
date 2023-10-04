using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour
{
    //dialogue canvas stuff
    public GameObject dialogueUI;
    public TextMeshProUGUI npcNameTMP;
    public TextMeshProUGUI npcDialogueTMP;

    //who is this controller attached to
    private NPC _npc;

    // Start is called before the first frame update
    void Start()
    {
        _npc = GetComponent<NPCController>().npc;

        Talk();
    }

    public void Talk() 
    {
        npcNameTMP.text = _npc.npcName;
        NextLine();
    }

    public void NextLine()
    {
        string currentLine = " ";

        //
        foreach(DialogueObject sentence in _npc.dialogue)
        {
            currentLine = sentence.sentence;
            npcDialogueTMP.text = currentLine;
        }

    }


}
