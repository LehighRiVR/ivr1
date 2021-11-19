using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterButtonSFX : MonoBehaviour
{
    public AudioSource upBubble;
    public AudioSource midBubble;
    public AudioSource downBubble;
    public AudioSource hover;
    public AudioSource openPanel;
    public AudioSource closePanel;


    public void popSound()
    {
        if (GameObject.Find("ButtonHolder").activeSelf == true)
        {
            upBubble.Play();
        }
        /*
        if (GameObject.Find("ButtonHolder").activeSelf == true && GameObject.Find("PROGRESSPanel").activeSelf == true || GameObject.Find("LOCATIONPanel").activeSelf == true || GameObject.Find("SETTINGSPanel").activeSelf == true)
        {
        downBubble.Play(); 
        }
        */         
    }

    public void BubbleSelect()
    {
        midBubble.Play();
    }

    public void hoverSound()
    {
        hover.Play();
    }

    /*
    public void openPanelSound()
    {
        openPanel.Play();
    }

        public void closePanelSound()
    {
        closePanel.Play();
    }
    

    public void PanelSounds()
    {
        if (progressPnl.activeInHierarchy == true)
        {
            openPanel.Play();
        }
        else if (progressPnl.activeInHierarchy != true)
        {
            closePanel.Play();
        }
                       
    }

    */
}
