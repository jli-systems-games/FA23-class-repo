using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScrollingText : MonoBehaviour
{
    [SerializeField][TextArea] private string[] script;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI scriptText;
    private int currentText = 0;
    public bool textDone = false;

    public GameObject continueText;
    public Animator textAnimation;

    public void Start()
    {
        SceneChange.textDone = false;
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        for (int i = 0; i < script[currentText].Length + 1; i++)
        {
            scriptText.text = script[currentText].Substring(0, i);
            yield return new WaitForSeconds(textSpeed);
            if (i == script[currentText].Length)
            {
                Debug.Log("TextDone");
                textDone = true;
                yield return new WaitForSeconds(2);
                textAnimation.SetTrigger("Done");
                SceneChange.textDone = true;
            }
        }


    }

}