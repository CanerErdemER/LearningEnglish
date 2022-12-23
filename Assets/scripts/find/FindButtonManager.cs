using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindButtonManager : MonoBehaviour
{
    AudioSource audioSource;
    public bool isItTrue;
    AudioSource[] AllaudioSource;
    Find_Controller Find_Controller;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        Find_Controller = FindObjectOfType<Find_Controller>();
    }
    public void MakeASound()
    {

        if (audioSource&&Find_Controller.isButtonUsable)
            StopAllSounds();
        audioSource.Play();
        if (isItTrue &&Find_Controller.isButtonUsable)
            StopAllSounds();
        audioSource.Play();
        
    }
    public void StopAllSounds()
    {
        AllaudioSource = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audio in AllaudioSource)
        {
            audio.Stop();
        }
    }
}
