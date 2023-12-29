using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentryShooter : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to spawn
    public float spawnDelayMin = 3f; // Minimum spawn delay in seconds
    public float spawnDelayMax = 8f; // Maximum spawn delay in seconds
    public float moveSpeed = 2f; // Speed at which the object moves down

    private float nextSpawnTime;

 /*   public Sprite idleSprite;
    public Sprite shootSprite;
    public Sprite hurtSprite;
    private SpriteRenderer spriteRenderer;*/

    public bool shootRight;

    public Sprite Sprite1;
    public Sprite Sprite2;
    public Sprite Sprite3;
    public Sprite Sprite4;
    public Sprite Sprite5;
    private SpriteRenderer spriteRenderer;

    public AudioClip shoot;
    private AudioSource audioSource;

    private void Start()
    {
        // Set the initial spawn time
        SetNextSpawnTime();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            SetNextSpawnTime();
            audioSource.PlayOneShot(shoot);
        }
    }

    private void SetNextSpawnTime()
    {
        nextSpawnTime = Time.time + Random.Range(spawnDelayMin, spawnDelayMax);
        //ChangeSprite(idleSprite);
    }

    private void SpawnObject()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

        //ChangeSprite(shootSprite);

        Rigidbody2D rb = newObject.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            if (shootRight == true)
            {
                rb.velocity = Vector2.right * moveSpeed;
                //audioSource.PlayOneShot(shoot);
                StartCoroutine(ChangeSpriteX2(Sprite1));
            }
            if (shootRight == false)
            {
                rb.velocity = Vector2.left * moveSpeed;
                //audioSource.PlayOneShot(shoot);
                StartCoroutine(ChangeSpriteX2(Sprite1));
            }
        }
    }

    IEnumerator ChangeSpriteX2(Sprite newSprite)
    {
        Debug.Log("1");
        ChangeSprite2(Sprite1);
        //ChangeSprite(shootSprite);

        yield return new WaitForSeconds(0.05f);

        Debug.Log("2");
        ChangeSprite2(Sprite2);

        yield return new WaitForSeconds(0.05f);

        Debug.Log("3");
        ChangeSprite2(Sprite3);

        yield return new WaitForSeconds(0.05f);

        Debug.Log("4");
        ChangeSprite2(Sprite4);

        yield return new WaitForSeconds(0.1f);

        Debug.Log("5");
        ChangeSprite2(Sprite5);

        yield return new WaitForSeconds(0.1f);

        Debug.Log("Done");
        ChangeSprite2(Sprite1);
    }


    void ChangeSprite2(Sprite newSprite)
    {
        //if (spriteRenderer != null && newSprite != null)
        //{
        spriteRenderer.sprite = newSprite;
        Debug.Log("changed");
        // }
    }


    /*    void ChangeSprite(Sprite newSprite)
        {
            // Change the sprite
            if (spriteRenderer != null && newSprite != null)
            {
                spriteRenderer.sprite = newSprite;
            }
        }*/
}
