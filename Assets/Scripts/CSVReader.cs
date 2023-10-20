using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CSVReader : MonoBehaviour
{
    public TextAsset npcData;
    public int numberColumns = 1;


    public void Awake()
    {
        ImportNPCs();
    }


    public void ImportNPCs()
    {
        string[] data = npcData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);

        int tableSize = (data.Length / numberColumns) - 1;

        for (int i = 0; i < tableSize; i++)
        {
            NPC tempNPC = new NPC();

            tempNPC.npcID = int.Parse(data[numberColumns * (i + 1)]);

            tempNPC.npcName = data[numberColumns * (i + 1) + 1];

            tempNPC.npcStrength = int.Parse(data[numberColumns * (i + 1) + 2]);
            tempNPC.npcDexterity = int.Parse(data[numberColumns * (i + 1) + 3]);
            tempNPC.npcConstitution = int.Parse(data[numberColumns * (i + 1) + 4]);
            tempNPC.npcIntelligence = int.Parse(data[numberColumns * (i + 1) + 5]);
            tempNPC.npcWisdom = int.Parse(data[numberColumns * (i + 1) + 6]);
            tempNPC.npcCharisma = int.Parse(data[numberColumns * (i + 1) + 7]);

            tempNPC.UpdateStats();

            GameData.npcDatabase.Add(tempNPC.npcID, tempNPC);

        }
    }

}
