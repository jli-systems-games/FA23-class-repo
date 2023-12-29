using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject objectPrefab;   // Prefab of the object to be instantiated
    public float moveSpeed = 5f;      // Speed of the instantiated object

    private int moveDirection = 0;    // 0 for left, 1 for right, 2 for up, 3 for down

    public AudioClip fire;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        // Check for player input to instantiate and move the object
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(fire);
            InstantiateObject();
        }

        // Check for input to set the move direction
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SetMoveDirection(0); // Set to move left
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SetMoveDirection(1); // Set to move right
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SetMoveDirection(2); // Set to move up
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetMoveDirection(3); // Set to move down
        }
    }

    void InstantiateObject()
    {
        // Instantiate the object
        GameObject newObj = Instantiate(objectPrefab, transform.position, Quaternion.identity);
        

        // Set the velocity of the instantiated object based on the move direction
        Rigidbody2D objRigidbody = newObj.GetComponent<Rigidbody2D>();
        if (objRigidbody != null)
        {
            Vector2 moveVector = GetMoveVector(moveDirection);
            objRigidbody.velocity = moveVector * moveSpeed;
        }
        else
        {
            Debug.LogError("The instantiated object must have a Rigidbody2D component for movement.");
        }
    }

    void SetMoveDirection(int direction)
    {
        // Set the move direction (0 for left, 1 for right, 2 for up, 3 for down)
        moveDirection = direction;
    }

    Vector2 GetMoveVector(int direction)
    {
        // Return a Vector2 based on the move direction
        switch (direction)
        {
            case 0: return Vector2.left;
            case 1: return Vector2.right;
            case 2: return Vector2.up;
            case 3: return Vector2.down;
            default: return Vector2.zero;
        }
    }
}
