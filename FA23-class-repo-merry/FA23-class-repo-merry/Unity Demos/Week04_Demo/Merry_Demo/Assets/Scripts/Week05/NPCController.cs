using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public NPC npc;
    public int npcID;

    public void Start()
    {
        npc = GameData.npcDatabase[npcID];

        Debug.Log(npc.npcName);
    }
}
