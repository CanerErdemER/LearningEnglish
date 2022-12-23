using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchExercisesButtonManager : MonoBehaviour
{
    public bool isItTrue;
    AudioSource audioSource;
    SearchExerciesesManager SearchExerciesesManager;
    AudioSource[] AllaudioSource;
    private void Awake()
    {
        audioSource=GetComponent<AudioSource>();
        SearchExerciesesManager = Object.FindObjectOfType<SearchExerciesesManager>();
    }
    public void MakeASound()
    {
        
        if (audioSource&&SearchExerciesesManager.isPressButton)
            StopAllSounds();
            audioSource.Play();
        if (isItTrue&&SearchExerciesesManager.isPressButton)
            StopAllSounds();
        audioSource.Play();
            SearchExerciesesManager.movePanel();        
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
