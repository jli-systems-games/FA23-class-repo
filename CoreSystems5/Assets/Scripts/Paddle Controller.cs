using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public GameObject sHold;
    public PointsManager pscript;
    
    void Start()
    {
        pscript = sHold.GetComponent<PointsManager>();
    }
    void Update()
    {
        if (transform.position.x >= -6 && transform.position.x <= 6)
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal")*0.06f, 0f, 0f);
        }
        else
        {
            if (transform.position.x < -6)
            {
                transform.position += new Vector3(0.01f, 0f, 0f);
            }
            else if (transform.position.x > 6)
            {
                transform.position += new Vector3(-0.01f, 0f, 0f);
            }
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        collider.rigidbody.AddForce(0f,5f,0f, ForceMode.Impulse);
        Debug.Log("asdf");
        pscript.PointsIncreaseBy10();
    }
}
