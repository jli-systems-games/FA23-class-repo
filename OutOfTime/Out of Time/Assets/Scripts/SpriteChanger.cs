using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite[] sprites;  // An array of sprites to cycle through
    public SpriteRenderer spriteRenderer;

    private int currentSpriteIndex = 0;
    private float timer = 0f;
    public float changeInterval = 1f; // Time interval in seconds to change the sprite

    private void Start()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        if (sprites.Length == 0)
        {
            Debug.LogError("No sprites assigned to the array.");
            enabled = false; // Disable the script if no sprites are assigned.
            return;
        }

        // Set the initial sprite
        spriteRenderer.sprite = sprites[currentSpriteIndex];
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeInterval)
        {
            // Change the sprite
            currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
            spriteRenderer.sprite = sprites[currentSpriteIndex];
            timer = 0f;
        }
    }
}
