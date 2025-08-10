using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class NearSign : MonoBehaviour
{
    [SerializeField] private RectTransform leftArrow;
    [SerializeField] private RectTransform rightArrow;
    [SerializeField] private GameObject Arrow;

    private void Start()
    {
        
    }

    public void DoArrowMove()
    {
        leftArrow.GetComponent<Image>().DOFade(1, 1);
        rightArrow.GetComponent<Image>().DOFade(1, 1);
        leftArrow.DOAnchorPosX(leftArrow.anchoredPosition.x + 0.5f, 0.5f);
        rightArrow.DOAnchorPosX(rightArrow.anchoredPosition.x - 0.5f, 0.5f);
    }

    public void UndoArrowMove()
    {
        leftArrow.GetComponent<Image>().DOFade(0, 0.75f);
        rightArrow.GetComponent<Image>().DOFade(0, 0.75f);
        leftArrow.DOAnchorPosX(leftArrow.anchoredPosition.x - 0.5f, 0.5f);
        rightArrow.DOAnchorPosX(rightArrow.anchoredPosition.x + 0.5f, 0.5f);
    }


}
