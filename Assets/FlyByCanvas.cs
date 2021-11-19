using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class FlyByCanvas : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public GameObject iconDrawer;
    public GameObject volumePanel;
    public GameObject subtitlesPanel;
    public GameObject panelBG;
    private Button button;
        

    public void Start()
    {
        
        button = iconDrawer.GetComponent<Button>();
        iconDrawer.GetComponent<CanvasGroup>().alpha = 0.75f;

        //panelBG.SetActive(false);  
      
    }
      
    public void OnPointerEnter(PointerEventData eventData)
    {
        ((IPointerEnterHandler)button).OnPointerEnter(eventData);

        iconDrawer.GetComponent<CanvasGroup>().alpha = 1.0f;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ((IPointerExitHandler)button).OnPointerExit(eventData);

        iconDrawer.GetComponent<CanvasGroup>().alpha = 0.25f;
  
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       ((IPointerClickHandler)button).OnPointerClick(eventData);             

        if (panelBG != null)
        {
            bool isActive = panelBG.activeSelf;
            panelBG.SetActive(!isActive);

        }
    }      
}
