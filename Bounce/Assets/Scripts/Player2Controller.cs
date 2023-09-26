using UnityEngine;

public class Player2Controller : MonoBehaviour
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

        // Check if any of the arrow keys are pressed for movement
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            isMoving = true;

            // Reset the "Idle" trigger to avoid interrupting animations
            animator.ResetTrigger("Idle");
        }

        // Check if the "M" key is pressed for punching
        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetTrigger("Punch");
        }

        // Set animation triggers for movement
        if (isMoving)
        {
            if (Input.GetKey(KeyCode.UpArrow))
                animator.SetTrigger("Forward");
            else if (Input.GetKey(KeyCode.DownArrow))
                animator.SetTrigger("Backward");
            if (Input.GetKey(KeyCode.RightArrow))
                animator.SetTrigger("Right");
            else if (Input.GetKey(KeyCode.LeftArrow))
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

        // Calculate movement based on arrow keys
        float horizontalInput = (Input.GetKey(KeyCode.RightArrow) ? 1f : 0f) - (Input.GetKey(KeyCode.LeftArrow) ? 1f : 0f);
        float verticalInput = (Input.GetKey(KeyCode.UpArrow) ? 1f : 0f) - (Input.GetKey(KeyCode.DownArrow) ? 1f : 0f);

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move Player 2
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    // Helper function to check if any animation is playing
    private bool IsAnyAnimationPlaying()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.normalizedTime < 1.0f;
    }
}
