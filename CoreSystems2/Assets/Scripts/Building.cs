using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
 
    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce(0.5f,0,0,ForceMode.Force);

        if (this.transform.position.x >= -20)
        {
            endSequence();
        }
    }

    public void endSequence()
    {
        Destroy(this);
        Debug.Log("dsf");
    }
}
