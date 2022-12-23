using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Star_Controller : MonoBehaviour
{
    [SerializeField]
    GameObject fstar1, fstar2, fstar3;
    [SerializeField]
    GameObject shinestar1, shinestar2, shinestar3;
    public void shineToStar(float value)
    {
        if (value < 12)
        {
            shinestar1.GetComponent<RectTransform>().DOScale(1, .2f).SetEase(Ease.OutBack);
            fstar1.GetComponent<Image>().fillAmount = value / 12f;
            

        }
        else if(value >= 12 && value > 24)
        {
            shinestar2.GetComponent<RectTransform>().DOScale(1, .2f).SetEase(Ease.OutBack);
            fstar2.GetComponent<Image>().fillAmount = value-12 / 12f;
            
        }
        else if (value >= 24 && value > 36)
        {
            shinestar3.GetComponent<RectTransform>().DOScale(1, .2f).SetEase(Ease.OutBack);
            fstar3.GetComponent<Image>().fillAmount = value-24 / 12f;
           
        }
        Invoke("offshine", .5f);

    }
    void offshine()
    {
        shinestar1.GetComponent<RectTransform>().DOScale(0, .2f);
        shinestar2.GetComponent<RectTransform>().DOScale(0, .2f);
        shinestar3.GetComponent<RectTransform>().DOScale(0, .2f);
    }
     

}
