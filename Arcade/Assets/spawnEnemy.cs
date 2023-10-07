using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemySpawner;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitSpawn());
    }

    IEnumerator waitSpawn()
    {
        yield return new WaitForSeconds(10f);
        enemySpawner.SetActive(true);
    }
}
