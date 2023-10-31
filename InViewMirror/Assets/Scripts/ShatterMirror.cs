using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterMirror : MonoBehaviour
{
    public GameObject[] mirrorPieces;
    public Collider playerCollider;
    public float explosionForce = 10f;

    private bool isShattered = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isShattered && IsPlayerNearMirror())
        {
            Shatter();
        }
    }

    bool IsPlayerNearMirror()
    {
        return playerCollider.bounds.Intersects(GetComponent<Collider>().bounds);
    }

    void Shatter()
    {
        isShattered = true;

        foreach (var piece in mirrorPieces)
        {
            piece.SetActive(true);

            Rigidbody rb = piece.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
                rb.AddForce(RandomForce(), ForceMode.Impulse);
            }
        }
    }

    Vector3 RandomForce()
    {
        return new Vector3(Random.Range(-explosionForce, explosionForce), Random.Range(-explosionForce, explosionForce), Random.Range(explosionForce, explosionForce * 2f));
    }
}
