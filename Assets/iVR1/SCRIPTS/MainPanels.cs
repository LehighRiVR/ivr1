using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanels : MonoBehaviour
{
    public GameObject progressPanel;
    public GameObject questionPanel;
    public GameObject convoPanel;
    public GameObject settingsPanel;
    public GameObject journalSubPanel;
    public GameObject gallerySubPanel;
    public GameObject glossarySubPanel;      

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void CLOSEallPANELS()
    {
        progressPanel.SetActive(false);
        questionPanel.SetActive(false);
        convoPanel.SetActive(false);
        settingsPanel.SetActive(false);
        Camera.main.GetComponent<LookAround>().enabled = true;
    }

    public void closeSubPanels()
    {
        journalSubPanel.SetActive(false);
        gallerySubPanel.SetActive(false);
        glossarySubPanel.SetActive(false);
        progressPanel.SetActive(true);
    }
    
}
