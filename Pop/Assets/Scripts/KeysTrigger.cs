using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysTrigger : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    public GameObject theKeys;
    public GameObject interactText;
    public GameObject keysSFX;

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
        theKeys.SetActive(false);
        keysSFX.SetActive(true);

    }
}