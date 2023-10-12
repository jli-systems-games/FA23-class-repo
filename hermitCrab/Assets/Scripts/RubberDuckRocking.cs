using System.Collections;
using UnityEngine;

public class RubberDuckRocking : MonoBehaviour
{
    public float rockingSpeed = 20.0f;  // Adjust the speed of rocking as needed.
    public float rockingAngle = 10.0f;  // Adjust the maximum rocking angle as needed.

    private float initialRotation;
    private float currentRotation;
    private bool isRockingForward = true;

    void Start()
    {
        // Store the initial rotation of the duck.
        initialRotation = transform.rotation.eulerAngles.x;
    }

    void Update()
    {
        // Calculate the new rotation angle based on the rocking animation.
        float targetRotation = isRockingForward ? initialRotation + rockingAngle : initialRotation - rockingAngle;
        currentRotation = Mathf.MoveTowards(currentRotation, targetRotation, rockingSpeed * Time.deltaTime);

        // Update the rotation of the duck.
        transform.rotation = Quaternion.Euler(currentRotation, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

        // Change the rocking direction when the duck reaches the target angle.
        if (Mathf.Approximately(currentRotation, targetRotation))
        {
            isRockingForward = !isRockingForward;
        }
    }
}
