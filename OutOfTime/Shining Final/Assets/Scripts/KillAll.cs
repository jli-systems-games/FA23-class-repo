using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillAll : MonoBehaviour
{
    public string bossLayerName = "Boss";

    void Start()
    {
        DeactivateObjectsInLayer(bossLayerName);
    }

    void DeactivateObjectsInLayer(string layerName)
    {
        int bossLayer = LayerMask.NameToLayer(layerName);

        Collider2D[] colliders = Physics2D.OverlapCircleAll(Vector2.zero, Mathf.Infinity, 1 << bossLayer);

        foreach (Collider2D collider in colliders)
        {
            GameObject obj = collider.gameObject;
            if (obj.layer == bossLayer)
            {
                obj.SetActive(false);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
