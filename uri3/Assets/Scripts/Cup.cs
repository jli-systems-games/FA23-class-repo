using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class Cup : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;

    public GameObject lid;

    private bool isFilled = false;

    private Outline outline;

    //public float _cycles = 3f;

    //public float endX = 0.0432f;
    //public float endY = -0.088f;
    //public float endZ = -0.0466f;

    //public float endZR = 55.401f;

    void Start()
    {
        currentHealth = maxHealth;

        outline = GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineColor = Color.red;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            CupFilled();
        }
    }

    void CupFilled()
    {
        isFilled = true;
        Debug.Log("Cup is filled!");
        lid.SetActive(true);
        if (outline != null)
        {
            outline.OutlineColor = new Color(0.0f, 1.0f, 0.0f);
        }

    }

    public bool IsFilled()
    {
        return isFilled;
    }
}

