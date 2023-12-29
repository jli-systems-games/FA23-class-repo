using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
    //public float moveSpeed = 5f; // Adjust the speed as needed.

    /* void Update()
     {
         if (Input.GetKey(KeyCode.UpArrow))
         {
             Vector3 newPosition = transform.position + Vector3.up * moveSpeed * Time.deltaTime;

             transform.position = newPosition;
         }

         if (Input.GetKey(KeyCode.DownArrow))
         {
             Vector3 newPosition = transform.position + Vector3.down * moveSpeed * Time.deltaTime;

             transform.position = newPosition;
         }

         if (Input.GetKey(KeyCode.RightArrow))
         {
             Vector3 newPosition = transform.position + Vector3.right * moveSpeed * Time.deltaTime;

             transform.position = newPosition;
         }
         if (Input.GetKey(KeyCode.LeftArrow))
         {
             Vector3 newPosition = transform.position + Vector3.left * moveSpeed * Time.deltaTime;

             transform.position = newPosition;
         }
     }*/
    Vector2 _movement;
    public float movementSpeed = 2f;
    private Rigidbody2D _rigidbody;
    Vector2 _previousPosition;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _previousPosition = _rigidbody.position;
    }
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * movementSpeed);

        _previousPosition = _rigidbody.position;
    }
}
