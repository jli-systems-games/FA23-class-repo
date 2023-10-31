using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBush : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
    }
}
