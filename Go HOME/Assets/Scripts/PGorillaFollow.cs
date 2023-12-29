using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGorillaFollow : MonoBehaviour
{
    public Transform target; // The target object to follow
    public float followSpeed = 2f; // Adjust the follow speed as needed

    void Update()
    {
        if (target != null)
        {
            // Calculate the new position to move towards the target
            Vector3 targetPosition = target.position;
            Vector3 newPosition = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

            // Move the object towards the new position
            transform.position = newPosition;
        }
    }
}
