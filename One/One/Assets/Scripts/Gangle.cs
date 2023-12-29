using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gangle : MonoBehaviour
{
    /*    public Sprite[] sprites;
        private SpriteRenderer spriteRenderer;
        private int currentSpriteIndex = 0;

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            InvokeRepeating("ChangeSprite", 1f, 1f);
        }

        private void ChangeSprite()
        {
            currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
            spriteRenderer.sprite = sprites[currentSpriteIndex];
        }*/
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    private int currentSpriteIndex = 0;

    private float timer = 0f;
    private float interval = 0.1f;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0f;
            ChangeSprite();
        }
    }

    private void ChangeSprite()
    {
        currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
        spriteRenderer.sprite = sprites[currentSpriteIndex];
    }
}
