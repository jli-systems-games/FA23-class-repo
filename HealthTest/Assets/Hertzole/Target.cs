using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hertzole.GoldPlayer;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public GameObject gameOver;
    public GameObject player;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        player.GetComponent<GoldPlayerInput>().enabled = false;
        player.GetComponent<GoldPlayerController>().enabled = false;

        gameOver.SetActive(true);

    }
}
