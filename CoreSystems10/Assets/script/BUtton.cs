using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BUtton : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI text;
    public string[] txtArray;

    private int index = 0;

    void Start()
    {
        text.text = txtArray[index];
    }
    public void onClick()
    {
        index++;

        if (index < txtArray.Length)
        {
            text.text = txtArray[index];
        }

        if (index == txtArray.Length)
        {
            canvas.SetActive(false);
        }
    }
}
