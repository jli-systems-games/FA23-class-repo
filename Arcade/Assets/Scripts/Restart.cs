using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class Restart : MonoBehaviour
{
    public GameObject blackCanvas;
    public RawImage blackScreen;

    void Start()
    {
        
    }

    
    void Update()
    {
        blackCanvas.SetActive(true);
        StartCoroutine(waitFade());
        blackScreen.DOFade(1f, 1f).SetEase(Ease.InSine);
    }

    IEnumerator waitFade()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(0);
    }
}
