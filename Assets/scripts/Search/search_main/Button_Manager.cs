using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Manager : MonoBehaviour
{
    AudioSource audioSource;
    private void Awake()
    {
        audioSource=GetComponent<AudioSource>();
    }
    public void MakeASound()
    {
        if (audioSource)
            audioSource.Play(); 
    }
}
