using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PROGRESSmanager : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Button JLbutton;
    public Button MGbutton;
    public Button GLbutton;

    public Image JLhighlight;
    public Image MGhighlight;
    public Image GLhighlight;

    public GameObject JLpanel;
    public GameObject MGpanel;
    public GameObject GLpanel;

    public GameObject PROGRESSpanel;

    // Start is called before the first frame update
    void Start()
    {
        //JLhighlight = GameObject.Find("JLbuttonHighlight");
        PROGRESSpanel = GameObject.Find("PROGRESSpanel");
        JLhighlight.enabled = false;
        MGhighlight.enabled = false;
        GLhighlight.enabled = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ((IPointerClickHandler)JLbutton).OnPointerClick(eventData);

        JLpanel.SetActive(true);
        PROGRESSpanel.SetActive(false);
        JLhighlight.enabled = false;

        ((IPointerClickHandler)MGbutton).OnPointerClick(eventData);

        MGpanel.SetActive(true);
        PROGRESSpanel.SetActive(false);
        MGhighlight.enabled = false;

        ((IPointerClickHandler)GLbutton).OnPointerClick(eventData);

        GLpanel.SetActive(true);
        PROGRESSpanel.SetActive(false);
        GLhighlight.enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ((IPointerEnterHandler)JLbutton).OnPointerEnter(eventData);

        JLhighlight.GetComponent<Image>().enabled = true;
        JLhighlight.enabled = true;

        ((IPointerEnterHandler)MGbutton).OnPointerEnter(eventData);

        MGhighlight.GetComponent<Image>().enabled = true;
        MGhighlight.enabled = true;

        ((IPointerEnterHandler)GLbutton).OnPointerEnter(eventData);

        GLhighlight.GetComponent<Image>().enabled = true;
        GLhighlight.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ((IPointerExitHandler)JLbutton).OnPointerExit(eventData);

        JLhighlight.GetComponent<Image>().enabled = false;
        JLhighlight.enabled = false;

        ((IPointerExitHandler)MGbutton).OnPointerExit(eventData);

        MGhighlight.GetComponent<Image>().enabled = false;
        MGhighlight.enabled = false;

        ((IPointerExitHandler)GLbutton).OnPointerExit(eventData);

        GLhighlight.GetComponent<Image>().enabled = false;
        GLhighlight.enabled = false;
    }

}
