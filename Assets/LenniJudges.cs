using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LenniJudges : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button next;
    public GameObject lenniBlock;
    public GameObject lenniAllow;

    public bool canAdvance;

    public void Start()
    {
        lenniBlock.SetActive(false);
        lenniAllow.SetActive(false);
        canAdvance = false;
    }

    void Update()
    {
        if (next.interactable == true)
        {
            canAdvance = true;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ((IPointerEnterHandler)next).OnPointerEnter(eventData);

        if (canAdvance)
        {
            lenniBlock.SetActive(false);
            lenniAllow.SetActive(true);
            //next.interactable = true;
        }
        else if (!canAdvance)
        {
            lenniBlock.SetActive(true);
            lenniAllow.SetActive(false);
           //next.interactable = false;
        }
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ((IPointerExitHandler)next).OnPointerExit(eventData);

        lenniBlock.SetActive(false);
        lenniAllow.SetActive(false);
    }

    /*
    public void LenniAllows()
    {
        canAdvance = true;
    }
    */
}
