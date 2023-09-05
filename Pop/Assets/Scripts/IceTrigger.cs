using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceTrigger : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    public GameObject theIce;
    public GameObject interactText;
    public GameObject iceSFX;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
            interactText.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
            interactText.SetActive(false);
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
        interactText.SetActive(false);
        theIce.SetActive(false);
        iceSFX.SetActive(true);

    }
}