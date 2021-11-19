using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class Tooltip : MonoBehaviour
{  
    public TextMeshProUGUI headerField;

    public TextMeshProUGUI contentField;

    public LayoutElement layoutElement;

    public int characterWrapLimit;

    public RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    

    public void SetText(string content, string header = "")
    {
        if (string.IsNullOrEmpty(header))
        {
            headerField.gameObject.SetActive(false);
        }
        else
        {
            //headerField.text = header;
            headerField.text = LocalizationSystem.GetLocalizedValue(header);
            headerField.gameObject.SetActive(true);
        }

        //contentField.text = content;
        contentField.text = LocalizationSystem.GetLocalizedValue(content);

        int headerLength = headerField.text.Length;
        int contentLength = contentField.text.Length;

        layoutElement.enabled = (headerLength > characterWrapLimit || contentLength > characterWrapLimit) ? true : false;

    }

    private void Update()
    {
        if (Application.isEditor)
        {
            int headerLength = headerField.text.Length;
            int contentLength = contentField.text.Length;

            layoutElement.enabled = (headerLength > characterWrapLimit || contentLength > characterWrapLimit) ? true : false;
        }

        Vector2 position = Input.mousePosition;

       
        float pivotX = position.x / Screen.width;
        float pivotY = position.y / Screen.height;

        rectTransform.pivot = new Vector2(0, 0);
      

        transform.position = position;

        //TooltipHEADER();
        //TooltipCONTENT();
    }

    /*
    public void TooltipHEADER()
    {
        
    }

    public void TooltipCONTENT()
    {
       
    }
    */
}
