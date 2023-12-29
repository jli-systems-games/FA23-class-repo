using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PCarLeftSpawner : MonoBehaviour
{
    public GameObject projectile1;
    public float spawnDelayMin = 3f;
    public float spawnDelayMax = 8f;
    public float moveSpeed = 2f;

    private float nextSpawnTime;

    public Sprite idleSprite;
    public Sprite shootSprite;
    public Sprite hurtSprite;
    private SpriteRenderer spriteRenderer;

    public AudioClip shoot;
    public AudioClip hurt;
    private AudioSource audioSource;

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
        nextSpawnTime = Time.time + Random.Range(spawnDelayMin, spawnDelayMax);
        //ChangeSprite(idleSprite);
    }

        private void SpawnObject()
        {
            GameObject newObject = Instantiate(projectile1, transform.position, Quaternion.identity);

            Rigidbody2D rb = newObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.down * moveSpeed;
            }

            //audioSource.PlayOneShot(shoot);
            StartCoroutine(ChangeSpriteX());
        //Invoke("ChangeSprite(idleSprite)", 1.0f);

    }

        void ChangeSprite(Sprite newSprite)
        {
            //if (spriteRenderer != null && newSprite != null)
            //{
                spriteRenderer.sprite = newSprite;
                Debug.Log("changed");
           // }
        }

        IEnumerator ChangeSpriteX()
        {
            Debug.Log("Change");
            ChangeSprite(shootSprite);
      
            yield return new WaitForSeconds(1f);

            Debug.Log("Idle");
            ChangeSprite(idleSprite);
        }

    IEnumerator ChangeSpriteHurt()
    {
        Debug.Log("Change");
        ChangeSprite(hurtSprite);

        yield return new WaitForSeconds(1f);

        Debug.Log("Idle");
        ChangeSprite(idleSprite);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            //ChangeSprite(hurtSprite);
            //Invoke("ChangeSprite(idleSprite)", 1.0f);
            audioSource.PlayOneShot(hurt);
            StartCoroutine(ChangeSpriteHurt());
        }
    }
}
