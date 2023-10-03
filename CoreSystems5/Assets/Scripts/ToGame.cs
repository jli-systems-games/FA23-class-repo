using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ToGame : MonoBehaviour
{
    public TextMeshProUGUI text;
    public bool isSeen;

    void Start()
    {
        StartCoroutine(textFlash());
    }

    IEnumerator textFlash()
    {
        if (isSeen){
            text.color = new Color(1.0f,1.0f,1.0f,0f);
            isSeen = !isSeen;
        }
        else{
            text.color = new Color(0.1747508f, 0.2839211f, 0.4811321f, 1.0f);
            isSeen = !isSeen;
        }

        yield return new WaitForSeconds(0.5f);
        StartCoroutine(textFlash());
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)){
            SceneManager.LoadScene("Game");
        }
    }
}
