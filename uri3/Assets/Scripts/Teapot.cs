using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Teapot : MonoBehaviour
{
    public GameObject teaPrefab;
    public float pourRate = 1.0f; 
    public float pourDistance = 1.0f;

    private Transform teaSpawnPoint;
    private float timeSinceLastPour;

    public ParticleSystem theTea;

    void Start()
    {
        teaSpawnPoint = transform.Find("TeaSpawnPoint");
    }

    void Update()
    {
        if (DDR.Pad.Cross)
        {
            PourTea();
        }
    }

    void PourTea()
    {
        if (Time.time - timeSinceLastPour >= 1.0f / pourRate)
        {
            timeSinceLastPour = Time.time;
            transform.DORotate(new Vector3(26, -90, 0), 1.5f).SetEase(Ease.InOutSine);
            theTea.Play();
            StartCoroutine(waitPour());
        }

        IEnumerator waitPour()
        {
            yield return new WaitForSeconds(2f);
            GameObject tea = Instantiate(teaPrefab, teaSpawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
            transform.DORotate(new Vector3(0, -90, 0), 2f).SetEase(Ease.InOutSine);
            yield return new WaitForSeconds(2f);
            theTea.Stop();
        }
    }
}


