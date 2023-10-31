using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public static float speed = 1.5f;
    private static float countTen;
    public bool flipped = true;

    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

        Swarm();
        countTen += Time.deltaTime;
        
        if (countTen >= 10)
        {
            Debug.Log("speedup");
            speed *= 1.1f;

            countTen = 0;
        }

    }

    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        if (player.transform.position.x-transform.position.x > 0 && flipped)
        {
            Flip();
        }
        if (player.transform.position.x - transform.position.x < 0 && !flipped)
        {
            Flip();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("EndScreen");

        }
    }
    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        flipped = !flipped;
    }
}
