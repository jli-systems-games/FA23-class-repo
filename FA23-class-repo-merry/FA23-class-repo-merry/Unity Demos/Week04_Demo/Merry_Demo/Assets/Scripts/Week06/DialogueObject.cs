using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static Player;

[CreateAssetMenu(fileName = "Dialogue", menuName = "ScriptableObjects/NPC/Dialogue", order = 2)]
public class DialogueObject : ScriptableObject
{
    public enum OperationType
    {
        GreaterThan, 
        LessThan, 
        EqualTo
    }

    public string sentence;
    public bool optional = false;

    public Stat optionStat;
    public int optionStatThreshold = 0;
    public OperationType operationType;

    public bool SayThis()
    {
        switch (operationType)
        {
            case OperationType.GreaterThan:
                if (Player.playerStats[optionStat] > optionStatThreshold)
                {
                    return true;
                }
                return false;
                //break;        You normally need break, it's just that this automatically returns

            case OperationType.LessThan:
                if (Player.playerStats[optionStat] < optionStatThreshold)
                {
                    return true;
                }
                return false;
                //break;

            case OperationType.EqualTo:
                if (Player.playerStats[optionStat] == optionStatThreshold)
                {
                    return true;
                }
                return false;
                //break;

            default:
                return false;
                //break;
        }
    }

}
