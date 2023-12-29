using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallllllll : MonoBehaviour
{
    public float pushForce2 = 5f;
    public float speed = 5f;
    public Rigidbody2D rb2;
    public GameObject player;

    private bool isMovingLeft = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isMovingLeft = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            isMovingLeft = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") && Input.GetKey(KeyCode.Space) && isMovingLeft == false)
        {
            /* rb2 = GetComponent<Rigidbody2D>();
             rb2.AddForce(new Vector2(-pushForce2, pushForce2), ForceMode2D.Impulse);*/
            player.transform.Translate(Vector2.up * speed * Time.deltaTime);
            player.transform.Translate(Vector2.left * speed * Time.deltaTime);
            Debug.Log("Luigi Pump");
        }
        if (collision.gameObject.CompareTag("Wall") && Input.GetKey(KeyCode.Space) && isMovingLeft == true)
        {
            /* rb2 = GetComponent<Rigidbody2D>();
             rb2.AddForce(new Vector2(-pushForce2, pushForce2), ForceMode2D.Impulse);*/
            player.transform.Translate(Vector2.up * speed * Time.deltaTime);
            player.transform.Translate(Vector2.right * speed * Time.deltaTime);
            Debug.Log("Rump");
        }
    }
}
