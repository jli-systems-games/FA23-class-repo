using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 10;
    private int currentHealth;
    public GameObject nextPhase;
    public GameObject extra1;
    public GameObject extra2;
    public GameObject extra3;
    public GameObject extra4;
    public GameObject extra5;
    public GameObject extra6;
    public GameObject extra7;
    public GameObject extra8;
    public GameObject extra9;
    public GameObject kill;
    public GameObject kill2;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        // Reduce enemy health
        currentHealth -= amount;

        // Check if the enemy should be destroyed
        if (currentHealth <= 0)
        {
            // Perform any additional actions when the enemy is defeated
            gameObject.SetActive(false);
            nextPhase.SetActive(true);
            extra1.SetActive(true);
            extra2.SetActive(true);
            extra3.SetActive(true);
            extra4.SetActive(true);
            extra5.SetActive(true);
            extra6.SetActive(true);
            extra7.SetActive(true);
            extra8.SetActive(true);
            extra9.SetActive(true);
            kill.SetActive(false);
            kill2.SetActive(false);

        }
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            kill.SetActive(false);
            kill2.SetActive(false);
        }
    }
}
