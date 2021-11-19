using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonToggle : MonoBehaviour
{   
    [Header("PANELS")]
    public GameObject progressPanel;
    public GameObject questionPanel;
    public GameObject convoPanel;
    public GameObject locationPanel;
    public GameObject settingsPanel;
    public GameObject kayakPanel;
    public GameObject foreGround;

    [Header("SUBPANELS")]
    public GameObject journalSubPanel;
    public GameObject gallerySubPanel;
    public GameObject glossarySubPanel;
    public GameObject infoSignSubPanel;

    [Header("ICONS")]
    public Image progressIcon;
    public Image questionIcon;
    public Image locationIcon;
    public Image settingsIcon;
    public Image convoIcon;
    public Image kayakIcon;

    [Header("BUTTONS")]
    public GameObject masterButton;
    public GameObject gameButtons;
    public GameObject fakeMasterButton;
    public GameObject progressButton;
    public GameObject questionButton;
    public GameObject locationButton;
    public GameObject settingsButton;
    public GameObject convoButton;
    public GameObject kayakButton;
    public Button progressBttn;
    public Button locationBttn;
    public Button settingsBttn;
    public Button convoBttn;

    

    void Start()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "EndMeetingPoint")
        {
            Camera.main.GetComponent<LookAround>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
         if (progressPanel.activeSelf == true | questionPanel.activeSelf == true | convoPanel.activeSelf == true | settingsPanel.activeSelf == true |
           journalSubPanel.activeSelf == true | gallerySubPanel.activeSelf == true | glossarySubPanel.activeSelf == true | infoSignSubPanel.activeSelf == true)
        {
            Camera.main.GetComponent<LookAround>().enabled = false;
        }

    }

    #region MASTER BUTTON // aka compass controller

    public void MasterButtonON()  // it shows the game buttons 
    {
        masterButton.SetActive(true);
    }

    public void MasterButtonOFF()  // it hides the game buttons 
    {
        masterButton.SetActive(false);
    }

    public void ToggleMasterButton () // this is not a toggle. this is a button that TOGGLES the game buttons from the compass controller
    {
        if (masterButton != null)
        {
            bool isActive = masterButton.activeSelf;
            masterButton.SetActive(!isActive);
        }        
    }

    #endregion

    #region ===================================================== QUESTION Button =====================================================

    public void questionButtonON()  // it shows the question panel 
    {
        questionButton.SetActive(true);
    }

    public void questionButtonOFF()  // it hides the question panel 
    {
        questionButton.SetActive(false);
    }

    public void ToggleQuestionPanel() // this is not a toggle. this is a button it TOGGLES the question Panel >> the question toggle >> compass controller
    {
        if (questionPanel != null)
        {
            bool isActive = questionPanel.activeSelf;
            questionPanel.SetActive(!isActive);
            ShowQuestionPanel();
            CameraLock();
        }        
    }   

    public void ShowQuestionPanel()
    {
        progressPanel.SetActive(false);
        convoPanel.SetActive(false);
        settingsPanel.SetActive(false);
        locationPanel.SetActive(false);
        masterButton.SetActive(false);
    }     

    public void TooltipQUESTIONButtonON()  // it shows the question panel tooltip on mouse over
    {        
        questionIconGROW();
    }

    public void TooltipQUESTIONButtonOFF() // it hides the question panel tooltip on mouse exit
    {
        questionIconSHRINK();
    }

    public void questionIconGROW()
    {
        questionIcon.rectTransform.sizeDelta = new Vector2(80, 80);
    }

    public void questionIconSHRINK()
    {
        questionIcon.rectTransform.sizeDelta = new Vector2(50, 50);
    }

    #endregion =====================================================

    #region ===================================================== PROGRESS Button =====================================================
       
    public void ToggleProgressPanel() // this is not a toggle. this is a button it TOGGLES the progress Panel >> the progress toggle >> compass controller
    {
        if (progressPanel != null)
        {
            bool isActive = progressPanel.activeSelf;
            progressPanel.SetActive(!isActive);  
            ShowProgressPanel();
            CameraLock();
        }
        
    }     

    public void ShowProgressPanel()
    {        
        questionPanel.SetActive(false);
        convoPanel.SetActive(false);
        settingsPanel.SetActive(false);
        journalSubPanel.SetActive(false); //LAST CHANGE
        gallerySubPanel.SetActive(false);
        glossarySubPanel.SetActive(false);
    }

    public void TooltipPROGRESSButtonON()  // it shows the question panel tooltip on mouse over
    {
        progressIconGROW();
    }

    public void TooltipPROGRESSButtonOFF() // it hides the question panel tooltip on mouse exit
    {
        progressIconSHRINK();
    }

    public void progressIconGROW()
    {
        progressIcon.rectTransform.sizeDelta = new Vector2(50, 50);
    }

    public void progressIconSHRINK()
    {
        progressIcon.rectTransform.sizeDelta = new Vector2(30, 30);
    }

    public void TooltipEndMeetingPointON()  // it shows the question panel tooltip on mouse over
    {
        progressIcon.rectTransform.sizeDelta = new Vector2(150, 150);
    }

    public void TooltipEndMeetingPointOFF() // it hides the question panel tooltip on mouse exit
    {
        progressIcon.rectTransform.sizeDelta = new Vector2(100, 100);
    }

    #endregion =====================================================

    #region ===================================================== CONVERSATION Button =====================================================

    public void ToggleconvoPanel() // this is not a toggle. this is a button it TOGGLES the progress Panel >> the progress toggle >> compass controller
    {
        if (convoPanel != null)
        {
            bool isActive = convoPanel.activeSelf;
            convoPanel.SetActive(!isActive);
            ShowConversationPanel();
            CameraLock();
        }        
    }

    public void ShowConversationPanel()
    {
        progressPanel.SetActive(false);
        questionPanel.SetActive(false);        
        settingsPanel.SetActive(false);
        journalSubPanel.SetActive(false);
        gallerySubPanel.SetActive(false);
        glossarySubPanel.SetActive(false);
    }

    public void TooltipCONVOButtonON()  // it shows the question panel tooltip on mouse over
    {
        convoIconGROW();
    }

    public void TooltipCONVOButtonOFF() // it hides the question panel tooltip on mouse exit
    {
        convoIconSHRINK();
    }

    public void convoIconGROW()
    {
        convoIcon.rectTransform.sizeDelta = new Vector2(50, 50);
    }

    public void convoIconSHRINK()
    {
        convoIcon.rectTransform.sizeDelta = new Vector2(30, 30);
    }

    #endregion =====================================================

    #region ===================================================== SETTINGS Button =====================================================

    public void ToggleSettingsPanel() // this is not a toggle. this is a button it TOGGLES the settings Panel >> the settings toggle >> compass controller
    {  
        if (settingsPanel != null)
        {
            bool isActive = settingsPanel.activeSelf;
            settingsPanel.SetActive(!isActive);                   
            ShowSettingsPanel();
            CameraLock();
        }
    }

    public void ShowSettingsPanel()
    {
        progressPanel.SetActive(false);
        questionPanel.SetActive(false);
        convoPanel.SetActive(false);
        journalSubPanel.SetActive(false);
        gallerySubPanel.SetActive(false);
        glossarySubPanel.SetActive(false);
    }

    public void TooltipSETTINGSButtonON()  // it shows the settings panel tooltip on mouse over
    {
        settingsIconGROW();
    }

    public void TooltipSETTINGSButtonOFF() // it hides the settings panel tooltip on mouse exit
    {
        settingsIconSHRINK();
    }

    public void settingsIconGROW()
    {
        settingsIcon.rectTransform.sizeDelta = new Vector2(50, 50);
    }

    public void settingsIconSHRINK()
    {
        settingsIcon.rectTransform.sizeDelta = new Vector2(30, 30);
    }

    #endregion

    #region ===================================================== LOCATION Button =====================================================

    public void ToggleLocationPanel() // this is not a toggle. this is a button it TOGGLES the location Panel >> the location toggle >> compass controller
    {        
        if (locationPanel != null)
        {
            bool isActive = locationPanel.activeSelf;
            locationPanel.SetActive(!isActive);
        }
    }

    public void TooltipLOCATIONButtonON()  // it shows the location panel tooltip on mouse over
    {
        locationIconGROW();
    }

    public void TooltipLOCATIONButtonOFF() // it hides the location panel tooltip on mouse exit
    {
        locationIconSHRINK();
    }

    public void locationIconGROW()
    {
        locationIcon.rectTransform.sizeDelta = new Vector2(50, 50);
    }

    public void locationIconSHRINK()
    {
        locationIcon.rectTransform.sizeDelta = new Vector2(30, 30);
    }

    #endregion =====================================================

    #region ===================================================== KAYAK Button =====================================================

    public void questionKayakON()  // it shows the question panel 
    {
        kayakButton.SetActive(true);
    }

    public void kayakButtonOFF()  // it hides the question panel 
    {
        kayakButton.SetActive(false);
    }

    public void ToggleKayakPanel() // this is not a toggle. this is a button it TOGGLES the question Panel >> the question toggle >> compass controller
    {
        if (questionPanel != null)
        {
            bool isActive = kayakPanel.activeSelf;
            kayakPanel.SetActive(!isActive);
            ShowKayakPanel();
            CameraLock();
        }
    }
    public void ToggleforeGround()
    {
        if (foreGround != null)
        {
            bool isActive = foreGround.activeSelf;
            foreGround.SetActive(!isActive);
        }
    }

    public void ShowKayakPanel()
    {
        progressPanel.SetActive(false);
        convoPanel.SetActive(false);
        settingsPanel.SetActive(false);
        journalSubPanel.SetActive(false);
        gallerySubPanel.SetActive(false);
        glossarySubPanel.SetActive(false);
    }

    public void kayakIconGROW()
    {
        kayakIcon.rectTransform.sizeDelta = new Vector2(80, 80);
    }

    public void kayakIconSHRINK()
    {
        kayakIcon.rectTransform.sizeDelta = new Vector2(50, 50);
    }

    #endregion =====================================================

    public void CLOSEallPANELS()
    {
        progressPanel.SetActive(false);
        questionPanel.SetActive(false);
        convoPanel.SetActive(false);
        settingsPanel.SetActive(false);
        kayakPanel.SetActive(false);
        infoSignSubPanel.SetActive(false);
        Camera.main.GetComponent<LookAround>().enabled = true;
    }
  

    public void ToggleFakeButton() // this is not a toggle. this is a button it TOGGLES the progress Panel >> the progress toggle >> compass controller
    {
        if (gameButtons != null)
        {
            bool isActive = gameButtons.activeSelf;

            gameButtons.SetActive(!isActive);

            DeactivateGameButtons();
        }

        void DeactivateGameButtons()
        {
            progressBttn.interactable = false;
            locationBttn.interactable = false;
            settingsBttn.interactable = false;
            convoBttn.interactable = false;
        }   
    }

 
    public void closeSubPanels()
    {     
        journalSubPanel.SetActive(false);
        gallerySubPanel.SetActive(false);
        glossarySubPanel.SetActive(false);
        progressPanel.SetActive(true);                
    } 
   
     
    public void CameraLock()
    {
        bool isLocked = Camera.main.GetComponent<LookAround>().enabled = false;
        Camera.main.GetComponent<LookAround>().enabled = !isLocked;
    }
}