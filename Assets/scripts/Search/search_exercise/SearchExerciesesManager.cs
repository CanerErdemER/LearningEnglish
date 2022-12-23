using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SearchExerciesesManager : MonoBehaviour
{
    int episodesNumber;
    public bool isPressButton;
    AudioClip AudioClip;
    AudioSource[] AllaudioSource;
    Star_Controller Star_Controller;
    private void Awake()
    {
        Star_Controller = Object.FindObjectOfType<Star_Controller>();
    }
    private void Start()
    {
        isPressButton = false;
        makeAsound();
    }
    public void movePanel()
    {
        if (episodesNumber >= 5)
            return;
        episodesNumber++;
        Star_Controller.shineToStar(episodesNumber);
        this.gameObject.GetComponent<RectTransform>().DOLocalMoveX(this.gameObject.GetComponent<RectTransform>().localPosition.x - 1280f, 0.5f);
        makeAsound();
    }
    void makeAsound()
    {
        isPressButton = false;
        Transform obje = this.gameObject.transform.GetChild(episodesNumber);
        for (int i = 0; i < 3; i++)
        {
            if (!obje.GetChild(i).GetComponent<SearchExercisesButtonManager>().isItTrue)
            {
                AudioClip = obje.GetChild(i).GetComponent<AudioSource>().clip;
                break;
            }
        }
        AudioSource.PlayClipAtPoint(AudioClip,Camera.main.transform.position);
        Invoke("ButtonCanBePressed", AudioClip.length);
    }
    private void ButtonCanBePressed()
    {
        isPressButton=true;
    }
    void StopAllSounds()
    {
        AllaudioSource = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach(AudioSource audio in AllaudioSource)
        {
            audio.Stop();
        }
    }
    public void repeatSounds()
    {
        StopAllSounds();
        makeAsound();
    }

}
