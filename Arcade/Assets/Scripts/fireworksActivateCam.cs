using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class fireworksActivateCam : MonoBehaviour
{
    public AudioSource woah;

    public float endX = -8.65f;
    public float endY = 1.79f;
    public float endZ = -28.63f;

    public float pauseX = -7.54f;
    public float pauseY = 1.8f;
    public float pauseZ = -13f;

    public float endXR = -39f;
    public float endYR = -47.8f;

    public float kidX = 0f;
    public float kidY = -191f;

    public float rightLookY = -131.8f;
    public float leftLookY = -291f;

    [SerializeField] private float _cycles = 12;
    [SerializeField] private float _dur = 4;

    public GameObject blackScreenCanvas;
    public RawImage blackScreen;

    public GameObject playerGold;
    public GameObject swat;
    public PostProcessVolume volume;
    public AudioSource fightSFX;
    public AudioSource annoSFX;
    public AudioSource happyBG;
    public AudioSource yellSFX;
    public GameObject aj;


    public GameObject[] objectsToDestroy;

    public void Start()
    {
        fireworkCamAnim();
    }
    public void fireworkCamAnim()
    {
        transform.DORotate(new Vector3(endXR, endYR, 0), _dur).SetEase(Ease.OutSine);
        transform.DOMove(new Vector3(pauseX, pauseY, pauseZ), 6).SetEase(Ease.InOutSine);

        StartCoroutine(waitforWoah());
        StartCoroutine(fireworksLooking());
    }

    IEnumerator waitforWoah()
    {
        yield return new WaitForSeconds(4f);
        woah.Play();
    }


    IEnumerator fireworksLooking()
    {

        yield return new WaitForSeconds(8f);

        transform.DOMove(new Vector3(endX, endY, endZ), _cycles).SetEase(Ease.InOutSine);
        transform.DORotate(new Vector3(kidX, kidY, 0), 6).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(8f);
        transform.DORotate(new Vector3(0, rightLookY, 0), 2f).SetEase(Ease.InOutSine);
        aj.SetActive(true);
        yield return new WaitForSeconds(3f);
        transform.DORotate(new Vector3(0, leftLookY, 0), 1f).SetEase(Ease.InOutSine);
        
        blackScreenCanvas.SetActive(true);
        yield return new WaitForSeconds(1f);
        yellSFX.Play();
        blackScreen.DOFade(1f, 0.5f).SetEase(Ease.InSine);
        yield return new WaitForSeconds(2f);
        playerGold.SetActive(false);
        swat.SetActive(true);
        transform.DORotate(new Vector3(-20, leftLookY, 0), 1f).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(3f);
        volume.weight = (1);
        happyBG.Pause();
        annoSFX.Play();
        fightSFX.Play();
        blackScreen.DOFade(0f,3f).SetEase(Ease.OutSine);
        yield return new WaitForSeconds(4f);
        blackScreenCanvas.SetActive(false);

        TriggerDestructionEvent();
    }

    public void TriggerDestructionEvent()
    {
        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
