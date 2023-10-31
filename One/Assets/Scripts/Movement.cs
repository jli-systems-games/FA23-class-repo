using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    
    private void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y);
        rb.velocity = new Vector2( rb.velocity.x,Input.GetAxisRaw("Vertical") * moveSpeed);

    }
}
