using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Search_Controller : MonoBehaviour
{
    [SerializeField]
    GameObject fade_img;

    AudioSource audioSource;
    void Start()
    {
       // fade_img.GetComponent<CanvasGroup>().DOFade(0, 1f).OnComplete(playStartVoice);
      
    }
    void playStartVoice()
    {
        if (audioSource)
        {
            audioSource.Play();
        }
    }
    public void nextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
