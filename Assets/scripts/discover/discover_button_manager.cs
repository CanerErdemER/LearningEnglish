using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discover_button_manager : MonoBehaviour
{
    [SerializeField]
    AudioSource AudioSource;
    private void Awake()
    {
        AudioSource = GetComponent<AudioSource>();

    }
    public void makeASound()
    {
        if(AudioSource != null)
        {
            AudioSource.Play();
        }
    }

}
