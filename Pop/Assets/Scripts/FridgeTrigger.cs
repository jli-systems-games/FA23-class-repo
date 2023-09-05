using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeTrigger : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private Animator myDoor = null;

    public GameObject fridgeTrigger;
    public GameObject interactText;
    public GameObject fridgeSFX;

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
        fridgeSFX.SetActive(true);
        myDoor.Play("doorOPen");
        fridgeTrigger.SetActive(false);
    }
}