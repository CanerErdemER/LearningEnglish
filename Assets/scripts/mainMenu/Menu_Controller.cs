using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{
    [SerializeField]
    GameObject logo_image;
    void Start()
    {
        openlogo();
    }

    void Update()
    {
        
    }

    void openlogo()
    {
        logo_image.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        logo_image.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void get_on_scene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
