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

    bool buttonĘsPressed;
    float pressedTime;
    float totalPressedTime=2f;
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonĘsPressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonĘsPressed = true;
    }
    void Update()
    {
        if (buttonĘsPressed)
        {
            holdFor2SecondsTxt.gameObject.SetActive(true);
            pressedTime += Time.deltaTime;
            if(pressedTime >= totalPressedTime)
            {
                buttonĘsPressed=false;
                holdFor2SecondsTxt.gameObject.SetActive(false);
                notesToParents.gameObject.SetActive(true);
            }

            loadFrame.fillAmount = pressedTime / totalPressedTime;
        }
        if (!buttonĘsPressed)
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
