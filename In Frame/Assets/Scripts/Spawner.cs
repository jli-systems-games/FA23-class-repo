using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject flowerPrefab;
    public GameObject birdPrefab;
    public GameObject mushroomPrefab;

    public Vector3[] spawnLocations1;
    public Vector3[] spawnLocations2;
    public Vector3[] spawnLocations3;
   
    private void Start()
    {
        spawnLocations1 = new[] { new Vector3(80.0999985f, 38.0400009f, 169.910004f), new Vector3(43.5499992f, 31.5300007f, 128.5f), new Vector3(61.6500015f, 33.4799995f, 106.489998f), new Vector3(42.0499992f, 31.4899998f, 80.3000031f), new Vector3(84.0199966f, 43.2799988f, 116.019997f)};
        spawnLocations2 = new[] { new Vector3(-48.6500015f, 32.3400002f, 82.4000015f), new Vector3(-78.8000031f, 37.2599983f, 92.8899994f), new Vector3(-87.4700012f, 40.1599998f, 111.669998f), new Vector3(-67.5999985f, 39.0900002f, 134.899994f), new Vector3(-40.7000008f, 31.6310005f, 134.899994f)};
        spawnLocations3 = new[] { new Vector3(-71.3499985f, 31.7630005f, 238.960007f), new Vector3(-50.6300011f, 31.0739994f, 239.660004f), new Vector3(-62.9000015f, 31.368f, 210.199997f), new Vector3(-66.9000015f, 32.5639992f, 190.565994f), new Vector3(-89.5199966f, 38.6139984f, 196.539993f) };

        var temp = Random.Range(1, 4);

        if (temp == 1)
        {
            flowerPrefab.transform.position=spawnLocations1[Random.Range(0,5)];
            birdPrefab.transform.position = spawnLocations2[Random.Range(0, 5)];
            mushroomPrefab.transform.position = spawnLocations3[Random.Range(0, 5)];
        }
        if (temp == 2)
        {
            flowerPrefab.transform.position = spawnLocations2[Random.Range(0, 5)];
            birdPrefab.transform.position = spawnLocations3[Random.Range(0, 5)];
            mushroomPrefab.transform.position = spawnLocations1[Random.Range(0, 5)];
        }
        if (temp == 3)
        {
            flowerPrefab.transform.position = spawnLocations3[Random.Range(0, 5)];
            birdPrefab.transform.position = spawnLocations1[Random.Range(0, 5)];
            mushroomPrefab.transform.position = spawnLocations2[Random.Range(0, 5)];
        }


    }
}
