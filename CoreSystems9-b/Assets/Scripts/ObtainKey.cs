using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtainKey : MonoBehaviour
{

    public GameObject trigObj;
    public GameObject canvasTrig;

    // Start is called before the first frame update
    void Start()
    {
        //trigObj.GetComponent<BoxCollider2D>().IsTrigger(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        trigObj.GetComponent<BoxCollider2D>().isTrigger = true;
        Destroy(canvasTrig);
        Destroy(gameObject);
    }
}
