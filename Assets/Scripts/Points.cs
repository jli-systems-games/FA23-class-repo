using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public int points;
    public GameObject spawner;
    public GameObject block;
    public TextMeshProUGUI score;
    public Camera cam;
    public Canvas Canvas;
    PersistPoints pp;
    public GameObject persist;

    DroppingCube droppingCube;
    private void Start()
    {
        GameObject textbox = GameObject.Find("Score");
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        score = textbox.GetComponent<TextMeshProUGUI>();
        droppingCube = spawner.GetComponent<DroppingCube>();
        GameObject persist = GameObject.Find("Persist");
        pp = persist.GetComponent<PersistPoints>();
    }

    private void Update()
    {
        if (spawner.transform.childCount == 1 && Input.GetKeyDown("space"))
        {
            points++;
            droppingCube.speed = droppingCube.speed + 5;
            score.text = points.ToString();

        }

    }
    void OnCollisionEnter(Collision collision)
    {
        var rb = GetComponent<Rigidbody>();

        if (collision.gameObject.tag == "Building")
        {

            /*points++;
             droppingCube.speed = droppingCube.speed +5;
             score.text = points.ToString(); */
            if (spawner.transform.childCount < 1)
            {
                var newBlock = Instantiate(block, spawner.transform.position, Quaternion.identity);
                var fall = newBlock.GetComponent<Rigidbody>();

                fall.useGravity = false;
                newBlock.transform.parent = spawner.transform;
            }
        }

        if (collision.gameObject.tag == "Base")
        {
            Debug.Log("GameOver");
            pp.Persistance();
            SceneManager.LoadScene("GameOver");

        }

    }
}
