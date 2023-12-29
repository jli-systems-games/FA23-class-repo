using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jscript2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject DeathScreen;
    public int HP = 10;
    private AudioSource _source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        Player.SetActive(true);
        DeathScreen.SetActive(false);
    }

    void Update()
    {
        if (HP <= 0)
        {
            GameOver();
        }
    }

    // Update is called once per frame
    void GameOver()
    {
        Player.SetActive(false);
        DeathScreen.SetActive(true);
    }

    public void Damage(int damage)
    {
        HP -= damage;
        _source.clip = clip;
        _source.Play();
        Debug.Log(HP);
    }
}
