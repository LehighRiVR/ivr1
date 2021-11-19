using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipSystem : MonoBehaviour
{
    private static TooltipSystem current;

    public Tooltip tooltip;

    public GameObject tp;
    
    public void Awake()
    {
        current = this;
    }

    public void Update()
    {
        if (tp.activeInHierarchy && (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1)))
        {
            tp.SetActive(false);
        }
    }

    public static void SHOWtooltip(string content, string header = "")
    {
        current.tooltip.SetText(content, header);
         current.tooltip.gameObject.SetActive(true);
        //current.Invoke("DELAYtooltip", 0.3f);
    }     

    public static void HIDEtooltip()
    {
        current.tooltip.gameObject.SetActive(false);
    }        
}
