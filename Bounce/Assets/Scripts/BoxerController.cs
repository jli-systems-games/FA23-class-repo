using UnityEngine;

public class BoxerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        bool isMoving = false;

        // Check if any of the WASD keys are pressed
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            isMoving = true;

            // Reset the "Idle" trigger to avoid interrupting animations
            animator.ResetTrigger("Idle");
        }

        // Check if the E key is pressed for punching
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("Punch");
        }

        // Set animation triggers for movement
        if (isMoving)
        {
            if (Input.GetKey(KeyCode.W))
                animator.SetTrigger("Forward");
            else if (Input.GetKey(KeyCode.S))
                animator.SetTrigger("Backward");
            if (Input.GetKey(KeyCode.D))
                animator.SetTrigger("Right");
            else if (Input.GetKey(KeyCode.A))
                animator.SetTrigger("Left");
        }
        else
        {
            // No keys pressed, play the "Idle" animation only if no other animations are playing
            if (!IsAnyAnimationPlaying())
            {
                animator.SetTrigger("Idle");
            }
        }

        // Calculate movement based on WASD keys
        float horizontalInput = (Input.GetKey(KeyCode.D) ? 1f : 0f) - (Input.GetKey(KeyCode.A) ? 1f : 0f);
        float verticalInput = (Input.GetKey(KeyCode.W) ? 1f : 0f) - (Input.GetKey(KeyCode.S) ? 1f : 0f);

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    // Helper function to check if any animation is playing
    private bool IsAnyAnimationPlaying()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.normalizedTime < 1.0f;
    }
}
