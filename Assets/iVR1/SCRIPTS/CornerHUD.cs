using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerHUD : MonoBehaviour
{
    public GameObject highlight;
    public GameObject masterButton;
    public GameObject compassRose;
    public GameObject buttonHolder;

    // Start is called before the first frame update
    void Start()
    {
        highlight.SetActive(true);
        masterButton.SetActive(true);
        compassRose.SetActive(true);
        buttonHolder.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}
