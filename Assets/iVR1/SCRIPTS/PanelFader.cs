using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelFader : MonoBehaviour
{
    public GameObject fading;

    public void Start()
    {
        fading.GetComponent<CanvasGroup>().alpha = 0.25f;
    }

    public void FadeIn()
    {
        fading.GetComponent<CanvasGroup>().alpha = 1.0f;
    }

    public void FadeOut()
    {
        fading.GetComponent<CanvasGroup>().alpha = 0.25f;
    }

}
