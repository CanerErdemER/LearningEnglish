using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScrollManager : MonoBehaviour
{
    int stageCount;
    public bool pressToButton;
    AudioClip clip;
    AudioSource[] allSoundsSource;
    private void Start()
    {
        pressToButton=false;
        makeASound();
    }
    public void movetoPanel()
    {
        this.gameObject.GetComponent<RectTransform>().DOLocalMoveX(this.gameObject.GetComponent<RectTransform>().localPosition.x - 1280, .5f);
        makeASound();
    }
    void makeASound()
    {
        pressToButton=false;
        Transform objecT = this.gameObject.transform.GetChild(stageCount);
        for (int i = 0; i < 3; i++)
        {
            if (!objecT.GetChild(i).GetComponent<searchExerciseButtonManager>().is_true)
            {
                clip = objecT.GetChild(i).GetComponent<AudioSource>().clip;
                break;
            }
        }
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
        Invoke("buttonCanBePressed", clip.length);

    }
    void buttonCanBePressed()
    {
        pressToButton=true;
    }
    void stopAllSounds()
    {
        allSoundsSource = FindObjectsOfType(typeof(AudioSource))as AudioSource[];
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
