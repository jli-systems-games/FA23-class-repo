using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public float force = 3f;
    public float moveSpeed = 1f;
    public Rigidbody2D catRigidbody;
    public bool flipped = true;

    void Start()
    {
        InvokeRepeating("ChangePosition", 0, 3);

    }
    private void Update()
    {
        catRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, catRigidbody.velocity.y);
        if (Input.GetAxisRaw("Horizontal") > 0&& !flipped)
        {
            Flip();
        }
        if (Input.GetAxisRaw("Horizontal") < 0 && flipped)
        {
            Flip();
        }
    }
    void ChangePosition()
    {
        Debug.Log("jump");
        catRigidbody.AddForce(transform.up * force);
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        flipped = !flipped;
    }


}
