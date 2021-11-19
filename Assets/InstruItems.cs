using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstruItems : MonoBehaviour
{
    public ScrollRect myScrollRect;
    public Scrollbar newScrollBar;

    public GameObject[] PostTestItems;
    public GameObject buttonPOSTEST;
    public GameObject[] MotivationItems;
    public GameObject buttonMOTIVATION;
    public GameObject[] PerceptionItems;
    public GameObject buttonPERCEPTION;
    public GameObject[] DemographicsItems;
    public GameObject buttonDEMOGRAPHICS;


    public void Start()
    {
        //PostTestItems.GetValue(0,1,2,3,4,5,6,7,8,9,10,11,12,13);
        
        //MotivationItems.GetValue(0,1,2,3,4,5,6,7,8,9,10,11,12,13,14);
         
        //PerceptionItems.GetValue(0,1,2,3,4,5,6,7,8,9,10,11,12,13,14);
          
        //DemographicsItems.GetValue(0, 1, 2, 3, 4, 5, 6);

        for (int i = 0; i < MotivationItems.Length; i++)
        {
            MotivationItems[i].SetActive(false);
        }

        for (int i = 0; i < PerceptionItems.Length; i++)
        {
            PerceptionItems[i].SetActive(false);
        }

        for (int i = 0; i < DemographicsItems.Length; i++)
        {
            DemographicsItems[i].SetActive(false);
        }
    }

    public void submitPOSTEST()
    {
        for (int i = 0; i < PostTestItems.Length; i++)
        {
            PostTestItems[i].SetActive(false);
        }
                
        for (int i = 0; i < MotivationItems.Length; i++)
        {
            MotivationItems[i].SetActive(true);
        }

        buttonPOSTEST.SetActive(false);

        //Change the current vertical scroll position.
        myScrollRect.verticalNormalizedPosition = 1f;
    }

    public void submitMOTIVATION()
    {
        for (int i = 0; i < MotivationItems.Length; i++)
        {
            MotivationItems[i].SetActive(false);
        }

        for (int i = 0; i < PerceptionItems.Length; i++)
        {
            PerceptionItems[i].SetActive(true);
        }

        buttonMOTIVATION.SetActive(false);

        //Change the current vertical scroll position.
        myScrollRect.verticalNormalizedPosition = 1f;
    }

    public void submitPERCEPTION()
    {
        for (int i = 0; i < PerceptionItems.Length; i++)
        {
            PerceptionItems[i].SetActive(false);
        }

        for (int i = 0; i < DemographicsItems.Length; i++)
        {
            DemographicsItems[i].SetActive(true);
        }

        buttonPERCEPTION.SetActive(false);

        //Change the current vertical scroll position.
        myScrollRect.verticalNormalizedPosition = 1f;
    }

    public void submitDEMOGRAPHICS()
    {
        for (int i = 0; i < DemographicsItems.Length; i++)
        {
            DemographicsItems[i].SetActive(false);
        }
               
        //dialogue ALL here
    }

}
