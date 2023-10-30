using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsTurn : MonoBehaviour
{
   
    public GameObject topull;
    public Countdown Cscript;
    public float turnSpeed ;

    void Start()
    {
        Cscript = topull.GetComponent<Countdown>();
        StartCoroutine(IncreaseTurnSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, turnSpeed, Space.Self);
    }

    private IEnumerator IncreaseTurnSpeed()
    {
        turnSpeed += 0.05f;
        yield return new WaitForSeconds(5f);
        StartCoroutine(IncreaseTurnSpeed());
    }

    void OnCollisionEnter(Collision collider)
    {
        Cscript.SubtractTime();
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(TimeSubtract());
    }

    private IEnumerator TimeSubtract()
    {
        yield return new WaitForSeconds(3f);
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
