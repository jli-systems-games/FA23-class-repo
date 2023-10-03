using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIClicked : MonoBehaviour
{
    public GameObject canvas;
    public GameObject holder;
    public TMP_Text textBox;

    public TextScroll script;
    
    void Start()
    {
        script = holder.GetComponent<TextScroll>();
    }

    public void OnClick()
    {
        script.counter++;
        canvas.SetActive(true);
        textBox.text = script.textBank[script.counter];
    }
}
