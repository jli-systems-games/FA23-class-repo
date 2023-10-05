using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMovement : MonoBehaviour
{
    public float force = 3f;
    public float moveSpeed = 1f;
    public Rigidbody rb;
    public bool jumping = false;
    public AudioSource jumpSound;
   
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y, Input.GetAxisRaw("Vertical") * moveSpeed);
        if (Input.GetKeyDown(KeyCode.Space) && jumping==false)
        {
            jumpSound.Play();
            rb.AddForce(Vector2.up * force, ForceMode.Impulse);
            jumping = true;
        }
       
       

    }
    private void OnCollisionEnter(Collision collision)
    {
        jumping = false;
    }
}
