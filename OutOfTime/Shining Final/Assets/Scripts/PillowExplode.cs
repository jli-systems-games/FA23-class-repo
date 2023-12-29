using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillowExplode : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    public Sprite newSprite;
    private float changeTime = 3f;
    private float elapsedTime = 0f;
    private bool hasChanged = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.enabled = false;
        Invoke("ActivateCollider", 2f);
    }

    private void ActivateCollider()
    {
        boxCollider.enabled = true;
    }
    private void Update()
    {
        if (!hasChanged)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= changeTime)
            {
                spriteRenderer.sprite = newSprite;
                hasChanged = true;
            }
        }
    }
}
