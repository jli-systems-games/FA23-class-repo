using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EggCollect : MonoBehaviour
{
    public static int eggsCollected;
    public TextMeshProUGUI countText;
    public AudioSource ding;
    void Start()
    {
        eggsCollected = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ding.Play();
        eggsCollected++;
        Destroy(gameObject);
        countText.text = eggsCollected.ToString();
        if (eggsCollected == 5)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
