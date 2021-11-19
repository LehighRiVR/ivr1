using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ConvoPlay : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Button convoBalloon;
    public Image soundON;
    public Image soundOFF;

    void Start()
    {
        soundON.enabled = true;
        soundOFF.enabled = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ((IPointerClickHandler)convoBalloon).OnPointerClick(eventData);

        if (soundON.enabled == true)
        {
            soundON.enabled = false;
            soundOFF.enabled = true;            
        }
        else if (soundOFF.enabled == true)
        {
            soundON.enabled = true;
            soundOFF.enabled = false;
        }
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ((IPointerEnterHandler)convoBalloon).OnPointerEnter(eventData);

        if (soundON)
        {
            soundON.color = new Color32(222, 182, 56, 255);
        }

        if (soundOFF)
        {
            soundOFF.color = new Color32(222, 182, 56, 255);
        }       
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ((IPointerExitHandler)convoBalloon).OnPointerExit(eventData);
                
        soundOFF.color = new Color32(41, 18, 7, 255);
        soundON.color = new Color32(41, 18, 7, 255);
    }
}
