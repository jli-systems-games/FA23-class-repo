using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carStart : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private Animator myExit = null;
    //public GameObject theKeys;
    public GameObject interactText;
    public GameObject engineSFX;
    public GameObject player3;
    public GameObject player4;
    //public GameObject hud;

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
        //theKeys.SetActive(false);
        engineSFX.SetActive(true);
        myExit.Play("fade2");
        StartCoroutine(moveDelay());

    }

    IEnumerator moveDelay()
    {
        yield return new WaitForSeconds(7f);
        //hud.SetActive(false);
        player3.SetActive(false);
        player4.SetActive(true);
    }
}