using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeapotController : MonoBehaviour
{
    public float movementSpeed = 5.0f;

    void Update()
    {
        float verticalInput = 0;
        float horizontalInput = 0;

        if (DDR.Pad.Up)
        {
            verticalInput += 1;
        }
        if (DDR.Pad.Down)
        {
            verticalInput -= 1;

        }

        if (DDR.Pad.Left)
        {
            horizontalInput += 1;
        }

        if (DDR.Pad.Right)
        {
            horizontalInput -= 1;
        }

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);
        
    }
}
