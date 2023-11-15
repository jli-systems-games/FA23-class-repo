
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Client", menuName = "ScriptableObjects/Client")]
public class Client : ScriptableObject
{
    public string nameTitle;
    public Color color;
    public string currentConcern;
    public string feeling;

    public string[] initialConvo;
    public string[] initialResponses;
   

    public string[] firstBranch;
    public string[] firstBranchResponses;
   


    public string[] secondBranch;
    public string[] secondBranchResponses;

    public string choiceOne;
    public string choiceTwo;
   
}
