using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increaser : MonoBehaviour
{
    // Start is called before the first frame update
    //public int increaserAmount = 1;
    public void Increase (int x)
    {
        GameManager.ScoreIncreased?.Invoke(x);
    }
}
