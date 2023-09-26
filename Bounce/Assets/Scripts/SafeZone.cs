using UnityEngine;
using TMPro;
using DG.Tweening;
public class SafeZone : MonoBehaviour
{
    public TMP_Text p1Win;
    public TMP_Text playAgain;
    public GameObject restartBtn;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            p1Win.DOFade(1f, 3f).SetEase(Ease.InOutSine);
            restartBtn.SetActive(true);
            playAgain.DOFade(1f, 5f).SetEase(Ease.InOutSine);

        }
    }
}
