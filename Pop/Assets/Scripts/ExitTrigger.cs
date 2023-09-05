using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private Animator myExit = null;
    //public GameObject theKeys;
    public GameObject interactText;
    public GameObject exitSFX;
    public GameObject player1;
    public GameObject player2;
    public GameObject hud;
    public GameObject home;

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
        exitSFX.SetActive(true);
        myExit.Play("fadeblack");
        StartCoroutine(moveDelay());

    }

    IEnumerator moveDelay()
    {
        yield return new WaitForSeconds(5f);
        home.SetActive(false);
        hud.SetActive(false);
        player1.SetActive(false);
        player2.SetActive(true);
    }
}