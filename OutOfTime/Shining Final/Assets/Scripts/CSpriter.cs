using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSpriter : MonoBehaviour
{
    public Sprite[] sprites;
    private int currentSpriteIndex = 0;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[currentSpriteIndex];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
            spriteRenderer.sprite = sprites[currentSpriteIndex];
        }
    }
}
