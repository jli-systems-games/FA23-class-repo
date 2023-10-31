using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TalkCount : MonoBehaviour
{
    public  TMP_Text count;

  
    public void CountUpdate(int i)
    {
        count.text = "Talked to " + i + "/7";
    }
}
