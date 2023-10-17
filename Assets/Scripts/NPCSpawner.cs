using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    //randomize everything
    public GameObject npcPrefab;
    public int spawnAmount = 0;
    public NPC randomBase;

    //offset
    public int npcDistance = 1;

    //weighting
    public Weapon[] weaponPool = new Weapon[0];

    //randomize from npc pool
    public List<NPC> npcPool = new List<NPC>();

    private void Awake()
    {
        SpawnNPC();
    }

    private void SpawnNPC()
    {
        #region Basic Randomization
        /*
        List<Vector3> previousLocations = new List<Vector3>();

        for (int i=0; i<spawnAmount; i++)
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

                foreach (Vector3 previous in previousLocations)
                {
                    float xOffset = previous.x - newVector.x;
                    float yOffset = previous.y - newVector.y;

                    if (Mathf.Abs(xOffset) <= npcDistance && Mathf.Abs(yOffset) <= npcDistance)
                    {
                        Debug.Log("BAD");
                        viable = false;
                        break;
                    }
                }

                if (badCounter > 100)
                {
                    Debug.Log("BAD");
                    break;
                }
            }


            if (viable == true)
            {
                GameObject newNPC = Instantiate(npcPrefab, newVector, Quaternion.identity);

                previousLocations.Add(newVector);

                newNPC.GetComponent<NPCController>().npc = randomBase;
                newNPC.GetComponent<NPCController>().npc.npcCharisma = Random.Range(8, 16);
                newNPC.GetComponent<NPCController>().npc.npcWeapon = weaponPool[Random.Range(0, weaponPool.Length - 1)];

                Debug.Log(newNPC.GetComponent<NPCController>().npc.npcWeapon.weaponName);

            }
        }
        */
        #endregion

        #region NPC Pool
        List<Vector3> previousLocations = new List<Vector3>();
        int listLength = npcPool.Count;

        for (int i = 0; i < listLength - 1; i++)
        {
            bool viable = false;
            Vector3 newVector = Vector3.zero;
            int badCounter = 0;

            while (viable == false)
            {
                //randomize location
                float x = Random.Range(-10f, 10f);
                float y = Random.Range(-10f, 10f);

                newVector = new Vector3(x, y, 0f);
                viable = true;

                foreach (Vector3 previous in previousLocations)
                {
                    float xOffset = previous.x - newVector.x;
                    float yOffset = previous.y - newVector.y;

                    if (Mathf.Abs(xOffset) <= npcDistance && Mathf.Abs(yOffset) <= npcDistance)
                    {
                        Debug.Log("BAD");
                        viable = false;
                        break;
                    }
                }

                if (badCounter > 100)
                {
                    Debug.Log("BAD");
                    break;
                }
            }


            if (viable == true)
            {
                GameObject newNPC = Instantiate(npcPrefab, newVector, Quaternion.identity);

                previousLocations.Add(newVector);

                int tempIndex = Random.Range(0, npcPool.Count);
                //Debug.Log(tempIndex);

                if(tempIndex != npcPool.Count)
                {
                    newNPC.GetComponent<NPCController>().npc = npcPool[tempIndex];
                    npcPool.RemoveAt(tempIndex);
                }



                Debug.Log(newNPC.GetComponent<NPCController>().npc.npcName);

            }
        }
        #endregion
    }
}