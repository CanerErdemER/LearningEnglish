using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class searchExerciseButtonManager : MonoBehaviour
{
    AudioSource audioSource;
    public bool is_true;
    ScrollManager ScrollManager;
    AudioSource[] allSoundsSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        ScrollManager = GetComponent<ScrollManager>();
    }
    public void MakeASound()
    {
        if (audioSource && ScrollManager.pressToButton)
        {
            stopAllSounds();
            audioSource.Play();

        }
        if (is_true && ScrollManager.pressToButton)
        {
            stopAllSounds();
            audioSource.Play();
            ScrollManager.movetoPanel();
        }
              

    }
    void stopAllSounds()
    {
        allSoundsSource = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audio in allSoundsSource)
        {
            audio.Stop();
        }
    }
    public void repeatSound()
    {
        stopAllSounds();
        MakeASound();
    }
}
   
