using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private Animator animator;

    public GameObject losingCanvas;
    public TMP_Text deathTxt;
    public TMP_Text againTxt;
    public AudioSource hurtSFX;
    public GameObject theGun;
    public GameObject startCanvas;
    void Start()
    {
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        hurtSFX.Play();
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }

   
    void Die()
    {
        
        theGun.GetComponent<Gun>().enabled = false;
        startCanvas.SetActive(false);
        losingCanvas.SetActive(true);
        Cursor.visible = true;
        deathTxt.DOFade(1f, 2f).SetEase(Ease.InOutSine);
        againTxt.DOFade(1f, 2f).SetEase(Ease.InOutSine);
        animator.SetBool("IsDead", true);
        this.GetComponent<PlayerMovement>().enabled = false;
        //this.GetComponent<Gun>().enabled = false;

    }

}
