using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public int maxHealth = 10;
    private int currentHealth;

    private Animator animator;

    public GameObject blackCanvas;
    public RawImage blackScreen;

    public AudioSource sirens;

    public GameObject winCanvas;
    public TMP_Text succTxt;
    public TMP_Text againTxt;

    public GameObject policeCar;

    public GameObject startCanvas;
    public GameObject theGun;

    public AudioSource enemyHurt;

    public GameObject endingCam;

    void Start()
    {
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        enemyHurt.Play();
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        theGun.GetComponent<Gun>().enabled = false;
        startCanvas.SetActive(false);
        Cursor.visible = true;
        animator.SetBool("IsDead", true);
        this.GetComponent<EnemyAI>().enabled = false;
        blackCanvas.SetActive(true);
        blackScreen.DOFade(1f, 4f).SetEase(Ease.InSine);
        StartCoroutine(waitFade());

    }

    IEnumerator waitFade()
    {
        yield return new WaitForSeconds(6f);
        sirens.Play();
        policeCar.SetActive(true);
        endingCam.SetActive(true);
        yield return new WaitForSeconds(5f);
        winCanvas.SetActive(true);
        succTxt.DOFade(1f, 1f).SetEase(Ease.InSine);
        againTxt.DOFade(1f, 1f).SetEase(Ease.InSine);
        
        blackScreen.DOFade(0f, 1f).SetEase(Ease.InSine);

        yield return new WaitForSeconds(1.2f);
        blackCanvas.SetActive(false);
        

    }
}
