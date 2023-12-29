using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player;
using static NPC;

public class NPCSpawner : MonoBehaviour
{
    //randomize everything
    public GameObject npcprefab;
    public int spawnAmount = 0;
    public NPC randomBase;

    //offset
    public int npcDistance = 1;

    public Weapon[] weaponPool = new Weapon[0];

    private void Awake()
    {
        SpawnNPC();
    }

    private void SpawnNPC()
    {
        List<Vector3> previousLocations = new List<Vector3>();

        for(int i = 0; i < spawnAmount; i++)
        {
            bool viable = false;
            Vector3 newVector = Vector3.zero;
            int badCounter = 0;

            while(viable == false)
            {
                //randomize location
                float x = Random.Range(-10f, 10f);
                float y = Random.Range(-10f, 10f);

                newVector = new Vector3(x, y, 0f);
                viable = true;

                foreach(Vector3 previous in previousLocations)
                {
                    float xOffset = previous.x - newVector.x;
                    float yOffset = previous.y - newVector.y;

                    if(Mathf.Abs(xOffset) <= npcDistance && Mathf.Abs(yOffset) <= npcDistance)
                    {
                        Debug.Log("BAD");
                        viable = false;
                        break;
                    }
                    if(badCounter > 100)
                    {
                        Debug.Log("BAD");
                        break;
                    }
                }
            }

            GameObject newNPC = Instantiate(npcprefab, newVector, Quaternion.identity);

            previousLocations.Add(newVector);

            newNPC.GetComponent<NPCController>().npc = randomBase;
            newNPC.GetComponent<NPCController>().npc.npcCharisma = Random.Range(8, 16);

            Debug.Log(newNPC.GetComponent<NPCController>().npc.npcCharisma);
        }
    }
}
