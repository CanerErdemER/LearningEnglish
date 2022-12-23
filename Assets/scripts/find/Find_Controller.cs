using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Find_Controller : MonoBehaviour
{
    int episodeNumber;
    AudioClip audioClip;
    public bool isButtonUsable;
    int numberofletter;
    AudioSource[] AllaudioSource;
    void Start()
    {
        StartCoroutine(OpenLetterRoutine());
    }
    IEnumerator OpenLetterRoutine()
    {
        makeAsound();
        GameObject obje = this.transform.GetChild(episodeNumber).gameObject;
        while (numberofletter < 3)
        {
            obje.transform.GetChild(numberofletter).GetComponent<CanvasGroup>().DOFade(1, 0.1f);
            yield return new WaitForSeconds(.2f);
            numberofletter++;
        }
    }
    void makeAsound()
    {
        isButtonUsable = false;
        Transform obje = this.gameObject.transform.GetChild(episodeNumber);
        audioClip = obje.GetComponent<AudioSource>().clip;

        AudioSource.PlayClipAtPoint(audioClip, Camera.main.transform.position);
        Invoke("ButtonCanBePressed", audioClip.length);
    }
    private void ButtonCanBePressed()
    {
        isButtonUsable = true;
    }
    void StopAllSounds()
    {
        AllaudioSource = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audio in AllaudioSource)
        {
            audio.Stop();
        }


    }
    public void repeatSounds()
    {
        StopAllSounds();
        makeAsound();
    }
    public void menureturn()
    {
        SceneManager.LoadScene("main_menu");
    }
}
