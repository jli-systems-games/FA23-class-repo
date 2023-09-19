using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class SuitUoTrigger : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    public GameObject theWeapon;
    public TMP_Text interact;
    public AudioSource pickUpSFX;
    public float fadeDuration = 1f;
    public GameObject thisTrigger;
    public GameObject exitWall;
    public GameObject block;

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

        theWeapon.SetActive(false);
        pickUpSFX.Play();
        interact.DOFade(0f, fadeDuration).SetEase(Ease.InOutSine);
        exitWall.SetActive(false);
        StartCoroutine(destroyDelay());
        block.GetComponent<Outline>().enabled = true;
    }

    IEnumerator destroyDelay()
    {
        yield return new WaitForSeconds(2f);

        GameObject.Destroy(thisTrigger);
    }      

}
