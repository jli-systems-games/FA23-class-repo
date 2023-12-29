using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PCameraFollow : MonoBehaviour
{
    public Transform target; // The target object to follow
    public float followSpeed = 2f; // Adjust the follow speed as needed

    void Update()
    {
        if (target != null)
        {
            float cameraX = target.position.x;
            float cameraY = target.position.y;
            Vector3 adjustedPosition = new Vector3(0f, cameraY, -10f);

            // Calculate the new position to move towards the target
            Vector3 targetPosition = adjustedPosition;
            Vector3 newPosition = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

            // Move the object towards the new position
            transform.position = newPosition;
        }
    }
}
