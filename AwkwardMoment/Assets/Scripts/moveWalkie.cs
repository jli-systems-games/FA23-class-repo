using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class moveWalkie : MonoBehaviour
{
    public GameObject walkieTalkie;
    public AudioSource white;
    public AudioSource intro;
    public AudioSource click;

    private Animator _anim;

    public TMP_Text jason;
    public float fadeDuration = 0.5f;

    public GameObject suitTrigger;

    public float endX = 0.15f;
    public float endY = -0.6f;
    public float endZ = -0.38f;

    void Start()
    {
        _anim = gameObject.GetComponent<Animator>();

        StartCoroutine(smallPause());
        StartCoroutine(whitePlay());
        StartCoroutine(waitMessage());
    }

    IEnumerator whitePlay()
    {
        yield return new WaitForSeconds(2f);
        white.Play();
        yield return new WaitForSeconds(2f);
        intro.Play();
        jason.DOFade(1f, fadeDuration).SetEase(Ease.InOutSine);
    }

    IEnumerator smallPause()
    {
        yield return new WaitForSeconds(9f);

        //intro.Play();
        StartCoroutine(introFinish());

    }

    IEnumerator introFinish()
    {
        yield return new WaitForSeconds(5f);
        jason.DOFade(0f, fadeDuration).SetEase(Ease.InOutSine);
        _anim.Play("storeWalkie");

        click.Play();

    }

IEnumerator waitMessage()
    {


        yield return new WaitForSeconds(16f);
        suitTrigger.SetActive(true);
        walkieTalkie.SetActive(false);

    }
}
