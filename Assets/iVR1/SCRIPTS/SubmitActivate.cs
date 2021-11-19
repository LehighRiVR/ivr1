using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitActivate : MonoBehaviour
{
    public GameObject selectionBox1;
    public bool box1 = false;
   

    public GameObject selectionBox2;
    public bool box2 = false;

    public GameObject selectionBox3;
    public bool box3 = false;

    public Button submitButton;

    public Sprite resetImage;

    void Start()
    {
        box1 = false;
        box2 = false;
        box3 = false;
    }

    void Update()
    {
        if (box1 == true && box2 == true && box3 == true)
        {
            submitButton.interactable = true;
        }
    }

    public void Reset()
    {
        box1 = false;
        box2 = false;
        box3 = false;

        selectionBox1.GetComponent<Image>().overrideSprite = resetImage;
        selectionBox2.GetComponent<Image>().overrideSprite = resetImage;
        selectionBox3.GetComponent<Image>().overrideSprite = resetImage;

        submitButton.interactable = false;
    }

}
