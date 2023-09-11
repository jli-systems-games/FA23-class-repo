using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public Vector3 theVector = new Vector3 (0,0,0);
    public Vector3 goVector = new Vector3 (3, 0, 0);
 
    public void startGoing()
    {
        this.GetComponent<Rigidbody>().velocity = goVector;

        
    }

    public void endSequence()
    {
        this.GetComponent<Rigidbody>().velocity = theVector;
    }
}
