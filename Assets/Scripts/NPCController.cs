using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCController : MonoBehaviour
{
    public NPC npc;
    public int npcID;

    private void Start()
    {
        npc = GameData.npcDatabase[npcID];

        Debug.Log(npc.npcName);
    }


}
