using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteOrder : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Set the order in layer to 0 when the up arrow is pressed
            GetComponent<Renderer>().sortingOrder = 2;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            // Set the order in layer to 1 when the down, left, or right arrows are pressed
            GetComponent<Renderer>().sortingOrder = 0;
        }
    }
}
