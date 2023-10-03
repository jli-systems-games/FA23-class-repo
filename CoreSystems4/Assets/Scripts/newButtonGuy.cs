using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject layer;
    public GameObject holder;
    public TMP_Text textBox;

    public TextScroll script;
    
    void Start()
    {
        script = holder.GetComponent<TextScroll>();
    }

    public void OnClick()
    {
        layer.SetActive(true);
        script.counter++;
        textBox.text = script.textBank[script.counter];
        Debug.Log(script.textBank[script.counter]);
    }
}
