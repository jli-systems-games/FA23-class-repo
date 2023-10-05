using System.Collections;
using TMPro;
using UnityEngine;

public class ScrollingText : MonoBehaviour
{
    [SerializeField][TextArea] private string[] script;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI scriptText;
    private int currentText = 0;
    public bool textDone = false;
    public GameObject text;
    public AudioSource typingNoise;

    public void Start()
    {
        StartCoroutine(AnimateText());
    }

    public void Update()
    {
        if (textDone == true)
        {
            StartCoroutine(showNext());
        }
    }



    IEnumerator AnimateText()
    {
        typingNoise.Play();

        for (int i = 0; i < script[currentText].Length + 1; i++)
        {
            scriptText.text = script[currentText].Substring(0, i);
            yield return new WaitForSeconds(textSpeed);
            if (i == script[currentText].Length)
            {
                Debug.Log("TextDone");
                textDone = true;
            }
        }


    }

    IEnumerator showNext()
    {
        typingNoise.Stop();
        yield return new WaitForSeconds(1f);
        text.gameObject.SetActive(true);
    }

}