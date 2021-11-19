using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonResize : MonoBehaviour
{
    public void iconGROW()
    {
        gameObject.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(130, 130);
    }

    public void iconSHRINK()
    {
        gameObject.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(100, 100);
    }

    public void buttonABSTRACT()
    {
        gameObject.GetComponent<Button>().interactable = false;
        gameObject.GetComponent<Image>().enabled = false;
        //gameObject.GetComponent<Image>().raycastTarget = false;
        //gameObject.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(100, 100);
        deactivateChildren();
    }

    public void activateChildren()
    {        
        for (int a = 0; a < transform.childCount; a++)

        transform.GetChild(a).gameObject.SetActive(true);             

    }

    public void deactivateChildren()
    {
         for (int a = 0; a < transform.childCount; a++)

         transform.GetChild(a).gameObject.SetActive(false);
        
    }

    public void STRETCHoutline()
    {
        gameObject.GetComponent<Outline>().effectDistance = new Vector2(55, 0);
    }

    public void RESEToutline()
    {
        gameObject.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
    }

    public void resizeEndMeetingPoint()
    {
        gameObject.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(125, 125);
    }

    public void DUMMYgrow()
    {
        gameObject.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(60, 60);
    }

    public void DUMMYshrink()
    {
        gameObject.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(40, 40);
    }
}
