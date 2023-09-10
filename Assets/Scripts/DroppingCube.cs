using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingCube : MonoBehaviour
{
    public GameObject spawner;
    public float speed;
    public bool movingLeft;
  

    void Start()
    {
        movingLeft = true;
    }
    void Update()
    {
        if(movingLeft == true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= -8) movingLeft = false;
            Debug.Log("moving left");
        }
        else
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= 8) movingLeft = true;
        }
        
        Debug.Log(spawner.transform.childCount);
       
        if (Input.GetKeyDown("space"))
        {
            GameObject block= spawner.transform.GetChild(0).gameObject;
            var fall= block.GetComponent<Rigidbody>();
            block.transform.SetParent(null);
            fall.useGravity = true;
        }
    }
}
