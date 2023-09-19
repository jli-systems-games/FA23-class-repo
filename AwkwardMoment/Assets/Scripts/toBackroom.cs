using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class toBackroom : MonoBehaviour
{
    [SerializeField] private Animator myExit = null;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(switchDelay());
        myExit.Play("fadeblack");
    }

    IEnumerator switchDelay()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);
    }
    
}
