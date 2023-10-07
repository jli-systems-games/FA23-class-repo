using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toGrab : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(grabWait());
    }

    IEnumerator grabWait()
    {
        yield return new WaitForSeconds(19.5f);
        animator.SetBool("IsRunning", true);
        yield return new WaitForSeconds(1f);
        animator.SetBool("IsRunning", false);
    }

}
