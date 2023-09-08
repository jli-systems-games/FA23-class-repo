using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteHitA : MonoBehaviour
{
    public bool canBePressed;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(canBePressed){
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="Activator")
        {
            canBePressed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag =="Activator")
        {
            canBePressed = false;
        }
    }
}
