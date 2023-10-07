using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;
using DG.Tweening;
public class beginGameCamAnim : MonoBehaviour
{

    public CinemachineVirtualCamera virtualCamera;
    public GameObject playBtn;
    public TMP_Text playTxt;
    public TMP_Text titleTxt;
    public GameObject thePlayer;

    private void Start()
    {
        thePlayer.SetActive(true);
        virtualCamera.m_Priority = 2;
        StartCoroutine(fadePlay());
        playTxt.DOFade(0f, 2f).SetEase(Ease.InOutSine);
        titleTxt.DOFade(0f, 2f).SetEase(Ease.InOutSine);
    }

    IEnumerator fadePlay()
    {
        yield return new WaitForSeconds(5f);
        playBtn.SetActive(false);
        Cursor.visible = false;
        Destroy(gameObject);
    }
}
