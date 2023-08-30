using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficultySelection : MonoBehaviour
{
    public string difficulty;

    public void setDifficultyEasy()
    {
        difficulty = "easy";
    }
    public void setDifficultyMedium()
    {
        difficulty = "medium";
    }
    public void setDifficultyHard()
    {
        difficulty = "hard";
    }
}
