using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletDown : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 5f;
    public float spawnForce = 5f;

    public AudioClip shoot;
    private AudioSource audioSource;

    private float nextSpawnTime;

    public bool shootDown;

    public Sprite Sprite1;
    public Sprite Sprite2;
    public Sprite Sprite3;
    public Sprite Sprite4;
    public Sprite Sprite5;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
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
        nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    private void SpawnObject()
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        Rigidbody2D rb = spawnedObject.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            
            if (shootDown == true)
            {
                //rb.AddForce(Vector2.down * spawnForce, ForceMode2D.Impulse);
                rb.velocity = Vector2.down * spawnForce;
                //audioSource.PlayOneShot(shoot);
                StartCoroutine(ChangeSpriteX3(Sprite1));
            }
            if (shootDown == false)
            {
                //rb.AddForce(Vector2.up * spawnForce, ForceMode2D.Impulse);
                rb.velocity = Vector2.up * spawnForce;
                //rb.velocity = Vector2.left * spawnForce;
                //audioSource.PlayOneShot(shoot);
                StartCoroutine(ChangeSpriteX3(Sprite1));
            }
        }
        //StartCoroutine(ChangeSpriteX3(Sprite1));
    }

    IEnumerator ChangeSpriteX3(Sprite newSprite)
    {
        Debug.Log("1");
        ChangeSprite3(Sprite1);
        //ChangeSprite(shootSprite);

        yield return new WaitForSeconds(0.05f);

        Debug.Log("2");
        ChangeSprite3(Sprite2);

        yield return new WaitForSeconds(0.05f);

        Debug.Log("3");
        ChangeSprite3(Sprite3);

        yield return new WaitForSeconds(0.05f);

        Debug.Log("4");
        ChangeSprite3(Sprite4);

        yield return new WaitForSeconds(0.1f);

        Debug.Log("5");
        ChangeSprite3(Sprite5);

        yield return new WaitForSeconds(0.1f);

        Debug.Log("Done");
        ChangeSprite3(Sprite1);
    }


    void ChangeSprite3(Sprite newSprite)
    {
        //if (spriteRenderer != null && newSprite != null)
        //{
        spriteRenderer.sprite = newSprite;
        Debug.Log("changed");
        // }
    }
}
