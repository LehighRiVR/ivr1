using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassTrigger : MonoBehaviour
{

    public GameObject nwInfo;
    public GameObject swInfo;
    public GameObject neInfo;
    public GameObject seInfo;

    void OnTriggerEnter2D()
    {
        //Debug.Log("Enter");
        if (gameObject.tag == "NW")
        {
            nwInfo.SetActive(true);
        }

        if (gameObject.tag == "SW")
        {
            swInfo.SetActive(true);
        }

        if (gameObject.tag == "NE")
        {
            neInfo.SetActive(true);
        }

        if (gameObject.tag == "SE")
        {
            seInfo.SetActive(true);
        }        
    }
  
    void OnTriggerExit2D()
    {
        //Debug.Log("Exit");

        if (gameObject.tag == "NW")
        {
            nwInfo.SetActive(false);
        }

        if (gameObject.tag == "SW")
        {
            swInfo.SetActive(false);
        }

        if (gameObject.tag == "NE")
        {
            neInfo.SetActive(false);
        }

        if (gameObject.tag == "SE")
        {
            seInfo.SetActive(false);
        }
    }
  
}
