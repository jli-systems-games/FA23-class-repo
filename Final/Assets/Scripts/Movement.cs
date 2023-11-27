using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    public Animator animator;
    public bool flipped = true;
    public bool up = false;
    public bool down = false;

    private void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
        if (Input.GetAxisRaw("Horizontal") > 0 && !flipped)
        {
            Flip();
            down = false;
            up = false;
        }
        if (Input.GetAxisRaw("Horizontal") < 0 && flipped)
        {
            Flip();
            down = false;
            up = false;
        }
        /* if (Input.GetAxisRaw("Vertical") > 0 )
         {
             down = false;
             up = true;
         }
         if (Input.GetAxisRaw("Vertical") < 0)
         {
             down = true;
             up = false;

         }*/
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        flipped = !flipped;
    }

}