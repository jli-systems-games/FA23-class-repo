using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeUP : MonoBehaviour
{

    public GameObject gotopull;
    public Countdown cscript;

    public float waitFor;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().enabled = false;
        this.GetComponent<SphereCollider>().enabled = false;
        cscript = gotopull.GetComponent<Countdown>();
        StartCoroutine(Respawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        cscript.AddTime(waitFor);
        this.GetComponent<MeshRenderer>().enabled = false;
        this.GetComponent<SphereCollider>().enabled = false;
        StartCoroutine(Respawn());
    }

    public IEnumerator Respawn()
    {
        yield return new WaitForSeconds(waitFor);
        this.GetComponent<MeshRenderer>().enabled = true;
        this.GetComponent<SphereCollider>().enabled = true;
        Debug.Log("asdf");
    }
}
