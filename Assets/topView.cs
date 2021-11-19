using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topView : MonoBehaviour
{
    public GameObject aerialView;

    public void Update()
    {
        if (aerialView.activeInHierarchy)
        {
            Camera.main.GetComponent<LookAround>().enabled = false;
        }        
    }

    public void reactivateCamera()
    {
         Camera.main.GetComponent<LookAround>().enabled = true; 
    }
}
