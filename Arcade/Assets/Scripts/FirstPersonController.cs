using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float movementSpeed = 5.0f; // Adjust the movement speed as needed
    public float rotationSpeed = 2.0f; // Adjust the rotation speed as needed
    private CharacterController characterController;
    private Animator playerAnimator;
    private bool isMoving = false;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Get input for player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector3 movement = transform.forward * verticalInput + transform.right * horizontalInput;

        // Rotate the player based on mouse input for looking around
        float rotationInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * rotationInput * rotationSpeed);

        // Move the character
        characterController.SimpleMove(movement * movementSpeed);

        // Check if the player is moving
        isMoving = movement.magnitude > 0;

        // Update the animator parameter
        playerAnimator.SetBool("IsMoving", isMoving);
    }
}
