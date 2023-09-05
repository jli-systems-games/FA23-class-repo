using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCrash : MonoBehaviour
{
    public GameObject crashSFX;
    public GameObject blackScreen;

    public void OnTriggerEnter(Collider other)
    {
        crashSFX.SetActive(true);
        StartCoroutine(endDelay());
    }
    IEnumerator endDelay()
    {
        yield return new WaitForSeconds(3.6f);
        blackScreen.SetActive(true);
        StartCoroutine(endScene());
    }

    IEnumerator endScene()
    {
        yield return new WaitForSeconds(9f);
        SceneManager.LoadScene("Ending");
    }
}
