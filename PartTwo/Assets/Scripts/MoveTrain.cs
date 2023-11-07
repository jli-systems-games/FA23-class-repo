using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTrain : MonoBehaviour
{
    public GameObject theTrain;
    public AudioSource trainSFX;
    private bool steppedIn = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !steppedIn)
        {
            trainSFX.Play();
            StartCoroutine(waitTrain());
            steppedIn = true;
        }
    }

    IEnumerator waitTrain()
    {
        yield return new WaitForSeconds(6f);
        

        theTrain.transform.DOMove(new Vector3(28.37f, 14.52f, -43.71f), 7f).SetEase(Ease.InOutSine);

    }
}
