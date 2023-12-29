using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallrender : MonoBehaviour
{
    public Sprite newSprite;
    public Sprite oldSprite;
    public SpriteRenderer spriteRenderer;
    public GameObject image;

    public GameObject objectToSlowDown;
    public float normalSpeed = 5f;
    public float slowSpeed = 2f;

/*    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("TOUCH!");
            image.GetComponent<SpriteRenderer>().sprite = newSprite;
            objectToSlowDown.GetComponent<Rigidbody2D>().velocity = objectToSlowDown.GetComponent<Rigidbody2D>().velocity.normalized * slowSpeed;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("no touch...");
            image.GetComponent<SpriteRenderer>().sprite = oldSprite;
            objectToSlowDown.GetComponent<Rigidbody2D>().velocity = objectToSlowDown.GetComponent<Rigidbody2D>().velocity.normalized * normalSpeed;
        }
    }
}
