using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite upSprite;
    public Sprite downSprite;
    public Sprite rightSprite;
    public Sprite leftSprite;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer component attached to the GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Make sure the required components are attached
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found on this GameObject.");
        }
        else if (upSprite == null || downSprite == null || rightSprite == null || leftSprite == null)
        {
            Debug.LogError("One or more sprites are not assigned to the script.");
        }
    }

    void Update()
    {
        // Check for input to change the sprite based on direction
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeSprite(upSprite);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChangeSprite(downSprite);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChangeSprite(rightSprite);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChangeSprite(leftSprite);
        }
    }

    void ChangeSprite(Sprite newSprite)
    {
        // Change the sprite
        if (spriteRenderer != null && newSprite != null)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}
