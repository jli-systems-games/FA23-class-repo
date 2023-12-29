using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using UnityEngine;


public class WeaponStuff : MonoBehaviour
{
    public TextAsset WeaponData;
    public int numberColumns = 1;

    public GameObject[] buttonPrefab;

    //public GameObject waterPrefab, roadPrefab, npcPrefab, grassPrefab;
     
    public void Awake()
    {
        //MakeLevel();
        ButtonGO();
    }

    public void Update()
    {

    }

    public void ButtonGO()
    {
        for (int i = 0; i < 3; i++)
        {
            var position = new Vector3(0, UnityEngine.Random.Range(0, Screen.height), 0);
            GameObject gameObject = Instantiate(buttonPrefab[UnityEngine.Random.Range(0, 9)], position, Quaternion.identity);
            Debug.Log(gameObject);
        }

    }
    /* public void MakeLevel()
     {
         string[] data = WeaponData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);

         int tableSize = (data.Length / numberColumns);

         for (int row = 0; row < tableSize; row++) //rows
         {
             for (int col = 0; col < numberColumns; col++) //columns
             {
                 string currentSquare = data[(row * numberColumns) + col];

                 Vector3 newVector = new Vector3(col, -(row), 0);

                 if (currentSquare != "")
                 {
                     if (currentSquare.All(char.IsDigit))
                     {
                         int npcID = int.Parse(currentSquare);

                         GameObject newNPC = Instantiate(npcPrefab, newVector, Quaternion.identity);
                     }
                     else
                     {
                         switch (currentSquare)
                         {
                             case "~":
                                 //spawn water
                                 Instantiate(waterPrefab, newVector, Quaternion.identity);
                                 break;
                             case "|":
                                 //spawn road
                                 Instantiate(roadPrefab, newVector, Quaternion.identity);
                                 break;
                             case "^":
                                 //spawn grass
                                 Instantiate(grassPrefab, newVector, Quaternion.identity);
                                 break;
                             default:
                                 break;
                         }
                     }
                 }
             }
         }
     }*/
}
