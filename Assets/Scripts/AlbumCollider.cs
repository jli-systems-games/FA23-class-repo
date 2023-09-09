using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AlbumCollider : MonoBehaviour
{
    [Header("Objects")]
    public int expectedObjects = 20;
    public int objectsInZone = 0;

    public TMP_Text score;

    [Header("Scene Fade")]
    public Image fadeImage; 
    public float fadeSpeed = 1.0f; 
    private bool isFading = false;


    void Start()
    {
        fadeImage.color = Color.clear; 
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("snw") || other.CompareTag("pony") || other.CompareTag("mop") || other.CompareTag("tna") || other.CompareTag("facelift") 
        || other.CompareTag("fame") || other.CompareTag("btw") || other.CompareTag("let") || other.CompareTag("orange") || other.CompareTag("hoh") 
        || other.CompareTag("letgo") || other.CompareTag("flyleaf") || other.CompareTag("bne") || other.CompareTag("sp") || other.CompareTag("riot") 
        || other.CompareTag("awkif") || other.CompareTag("wcpgw") || other.CompareTag("sunburn") || other.CompareTag("soad") || other.CompareTag("loathe"))
        {
            objectsInZone++;
            score.text = objectsInZone + "/20";
            CheckAllObjectsInZone();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("snw") || other.CompareTag("pony") || other.CompareTag("mop") || other.CompareTag("tna") || other.CompareTag("facelift") 
        || other.CompareTag("fame") || other.CompareTag("btw") || other.CompareTag("let") || other.CompareTag("orange") || other.CompareTag("hoh") 
        || other.CompareTag("letgo") || other.CompareTag("flyleaf") || other.CompareTag("bne") || other.CompareTag("sp") || other.CompareTag("riot") 
        || other.CompareTag("awkif") || other.CompareTag("wcpgw") || other.CompareTag("sunburn") || other.CompareTag("soad") || other.CompareTag("loathe"))
        {
            objectsInZone--;
            score.text = objectsInZone + "/20";
            CheckAllObjectsInZone();
        }
    }

    private void CheckAllObjectsInZone()
    {
        if (objectsInZone == expectedObjects && !isFading)
        {
            StartCoroutine(FadeToBlack());

            Debug.Log("All objects are in the trigger zone!");
        }
    }

    IEnumerator FadeToBlack()
    {
        isFading = true;

        Color currentColor = fadeImage.color;
        Color targetColor = Color.black;

        float elapsedTime = 0;

        while (elapsedTime < 1.0f / fadeSpeed)
        {
            fadeImage.color = Color.Lerp(currentColor, targetColor, elapsedTime * fadeSpeed);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        fadeImage.color = targetColor;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("EndScene");


        isFading = false;
    }
}
