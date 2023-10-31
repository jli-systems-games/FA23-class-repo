using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject reaperPrefab;

    [SerializeField]
    private float swarmerInterval;

    private float[] xpos = { 11, -11 };

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, reaperPrefab));
        
    }

    private void Update()
    {
        if (Timer.count < 10)
        {
            
            swarmerInterval = Random.Range(3f, 5f);
        }
        else if (Timer.count >= 10 && Timer.count < 20)
        {
            swarmerInterval = Random.Range(2f, 3f);
        }
        else if (Timer.count >= 20 && Timer.count < 30)
        {
            swarmerInterval = Random.Range(1f, 2f);
        }
        else if (Timer.count >= 30 && Timer.count < 40)
        {
            swarmerInterval = Random.Range(0.5f, 1f);
        }
        else if (Timer.count >= 40 && Timer.count < 50)
        {
            swarmerInterval = Random.Range(0.01f, 0.5f);
        }
        else if (Timer.count >= 50)
        {
            swarmerInterval = Random.Range(0.005f, 0.01f);
        }
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        var i = Random.Range(0, 2);
        GameObject newEnemy = Instantiate(enemy, new Vector3(xpos[i], Random.Range(5f, -5f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(swarmerInterval, enemy));
    }
}
