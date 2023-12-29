using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSprite : MonoBehaviour
{
    public Sprite[] sprites; // Array of sprites
    private int currentSpriteIndex = 0; // Index to track the current sprite

    // Function to change the sprite based on the current index
    private void ChangeSprite()
    {
        if (currentSpriteIndex < sprites.Length)
        {
            // Change the sprite of the SpriteRenderer component
            GetComponent<SpriteRenderer>().sprite = sprites[currentSpriteIndex];
        }
    }

    // Function to increase the variable by 1 and change the sprite
    public void IncreaseVariableAndChangeSprite()
    {
        // Increase the variable
        currentSpriteIndex++;

        // Check if the index is within the bounds of the sprite array
        if (currentSpriteIndex >= sprites.Length)
        {
            currentSpriteIndex = 0; // Reset to the first sprite if it exceeds the array length
        }

        // Change the sprite
        ChangeSprite();
    }
}
