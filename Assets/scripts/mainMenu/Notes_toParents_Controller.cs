using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Notes_toParents_Controller : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField]
    Text holdFor2SecondsTxt;
    [SerializeField]
    Image loadFrame;
    [SerializeField]
    GameObject notesToParents;

    bool button›sPressed;
    float pressedTime;
    float totalPressedTime=2f;
    public void OnPointerUp(PointerEventData eventData)
    {
        button›sPressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        button›sPressed = true;
    }
    void Update()
    {
        if (button›sPressed)
        {
            holdFor2SecondsTxt.gameObject.SetActive(true);
            pressedTime += Time.deltaTime;
            if(pressedTime >= totalPressedTime)
            {
                button›sPressed=false;
                holdFor2SecondsTxt.gameObject.SetActive(false);
                notesToParents.gameObject.SetActive(true);
            }

            loadFrame.fillAmount = pressedTime / totalPressedTime;
        }
        if (!button›sPressed)
        {
            pressedTime-= Time.deltaTime;
            if(pressedTime<= 0)
            {
                pressedTime=0;
            }
            loadFrame.fillAmount = pressedTime / totalPressedTime;
        }
        
    }
    public void notesToParentsQuit()
    {
        notesToParents.SetActive(false);
    }
    
}
