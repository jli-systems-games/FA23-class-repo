using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static VLB.MaterialModifier;

public class blobPick : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private Animator myExit = null;
    public float fadeDuration = 1f;
    public TMP_Text interact;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
            interact.DOFade(1f, fadeDuration).SetEase(Ease.InOutSine);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
            interact.DOFade(0f, fadeDuration).SetEase(Ease.InOutSine);
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.E))
        {
            SomeCoolAction();
        }
    }

    public void SomeCoolAction()
    {
        StartCoroutine(switchDelay());
        myExit.Play("fadeblack");
    }

    IEnumerator switchDelay()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(2);
    }
}
