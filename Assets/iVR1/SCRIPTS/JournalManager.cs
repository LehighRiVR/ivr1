using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JournalManager : MonoBehaviour
{
    #region DECLARED GAMEOBJECTS

    public GameObject JournalLogo;           

    [Header("PAGES")]
    public GameObject FrancisJournal;
    public GameObject RockportJournal;
    public GameObject LehighGapJournal;
    public GameObject WalnutportJournal;
    public GameObject CementonJournal;
    public GameObject ThomasIronJournal;
    public GameObject AllentownJournal;
    public GameObject BethlehemJournal;
    public GameObject EastonJournal;

    [Header("ENTRIES")]

    public GameObject Francis1;
    public GameObject Francis2a;
    public GameObject Francis2b;

    public GameObject Rockport1;
    public GameObject Rockport2a;
    public GameObject Rockport2b;

    public GameObject LehighGap1;
    public GameObject LehighGap2;
    public GameObject LehighGap3a;
    public GameObject LehighGap3b;

    public GameObject Walnutport2a;
    public GameObject Walnutport2b;
    public GameObject Walnutport3;

    public GameObject Cementon1a;
    public GameObject Cementon1b;

    public GameObject Hamilton1a;
    public GameObject Hamilton1b;
    public GameObject Hamilton1c;

    public GameObject Thomas1a;
    public GameObject Thomas1b;

    public GameObject Bethlehem1;
    public GameObject Bethlehem2;
    public GameObject Bethlehem3;

    public GameObject Easton1;
    public GameObject Easton2;
    public GameObject Easton3;

    [Header("???")]

    public GameObject Francis1Hid;
    public GameObject Francis2aHid;
    public GameObject Francis2bHid;

    public GameObject Rockport1Hid;
    public GameObject Rockport2aHid;
    public GameObject Rockport2bHid;

    public GameObject LehighGap1Hid;
    public GameObject LehighGap2Hid;
    public GameObject LehighGap3aHid;
    public GameObject LehighGap3bHid;

    public GameObject Walnutport2aHid;
    public GameObject Walnutport2bHid;
    public GameObject Walnutport3Hid;

    public GameObject Cementon1aHid;
    public GameObject Cementon1bHid;

    public GameObject Hamilton1aHid;
    public GameObject Hamilton1bHid;
    public GameObject Hamilton1cHid;

    public GameObject Thomas1aHid;
    public GameObject Thomas1bHid;

    public GameObject Bethlehem1Hid;
    public GameObject Bethlehem2Hid;
    public GameObject Bethlehem3Hid;

    public GameObject Easton1Hid;
    public GameObject Easton2Hid;
    public GameObject Easton3Hid;

    #endregion

    // Start is called before the first frame update
    void Start()
    {       
        resetJournalPages();
        activateHIDDEN();
        hideENTRIES();

        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        //Debug.Log(currentScene.name);               

        if (sceneName == "FRANCISW1B")
        {
            Francis1.SetActive(true);
            Francis1Hid.SetActive(false);
        }

        if (sceneName == "FRANCISW2B")
        {
            FRANCISreloaded();
        }

        if (sceneName == "ROCKPORT1")
        {
            FRANCISreloaded();
            Rockport1.SetActive(true);
            Rockport1Hid.SetActive(false);
        }

        if (sceneName == "ROCKPORT2")
        {
            ROCKPORTreloaded();            
        }

        if (sceneName == "LGNC1")
        {
            ROCKPORTreloaded();
            LehighGap1.SetActive(true);
            LehighGap1Hid.SetActive(false);
        }

        if (sceneName == "LGNC2")
        {
            ROCKPORTreloaded();
            LehighGap1.SetActive(true);
            LehighGap1Hid.SetActive(false);
            LehighGap2.SetActive(true);
            LehighGap2Hid.SetActive(false);
        }

        if (sceneName == "LGNC3")
        {
            LGNCreloaded();            
        }

        if (sceneName == "WALNUTPORT1")
        {
            LGNCreloaded();
        }

        if (sceneName == "WALNUTPORT2")
        {
            LGNCreloaded();
            Walnutport2a.SetActive(true);
            Walnutport2b.SetActive(true);
            Walnutport2aHid.SetActive(false);
            Walnutport2bHid.SetActive(false);
        }

        if (sceneName == "WALNUTPORT3")
        {
            WALNUTreloaded();
           
        }

        if (sceneName == "CEMENTON")
        {
            WALNUTreloaded();
            CEMENTreloaded();
        }

        if (sceneName == "THOMASIRON")
        {
            THOMASreloaded();
        }

        if (sceneName == "ALLENTOWN")
        {
            HAMILTONreloaded();
        }

        if (sceneName == "BETHLEHEM1")
        {
            HAMILTONreloaded();
            Bethlehem1.SetActive(true);
            Bethlehem1Hid.SetActive(false);
        }

        if (sceneName == "BETHLEHEM2")
        {
            HAMILTONreloaded();
            Bethlehem1.SetActive(true);
            Bethlehem1Hid.SetActive(false);
            Bethlehem2.SetActive(true);
            Bethlehem2Hid.SetActive(false);
        }

        if (sceneName == "BETHLEHEM3")
        {
            BETHLEHEMreloaded();
            
        }

        if (sceneName == "EASTON1")
        {
            BETHLEHEMreloaded();
            Easton1.SetActive(true);
            Easton1Hid.SetActive(false);
        }

        if (sceneName == "EASTON2")
        {
            BETHLEHEMreloaded();
            Easton1.SetActive(true);
            Easton1Hid.SetActive(false);
            Easton2.SetActive(true);
            Easton2Hid.SetActive(false);
        }

        if (sceneName == "EASTON3" || sceneName == "EndMeetingPoint" || sceneName == "360player" || sceneName == "POSTtest")
        {
            EASTONreloaded();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region RELOADING SCENES

    public void FRANCISreloaded()
    {
        Francis1.SetActive(true);
        Francis2a.SetActive(true);
        Francis2b.SetActive(true);
        Francis1Hid.SetActive(false);
        Francis2aHid.SetActive(false);
        Francis2bHid.SetActive(false);
    }

    public void ROCKPORTreloaded()
    {
        FRANCISreloaded();
        Rockport1.SetActive(true);
        Rockport1Hid.SetActive(false);
        Rockport2a.SetActive(true);
        Rockport2b.SetActive(true);
        Rockport2aHid.SetActive(false);
        Rockport2bHid.SetActive(false);
    }

    public void LGNCreloaded()
    {
        FRANCISreloaded();
        ROCKPORTreloaded();
        LehighGap1.SetActive(true);
        LehighGap1Hid.SetActive(false);
        LehighGap2.SetActive(true);
        LehighGap2Hid.SetActive(false);
        LehighGap3a.SetActive(true);
        LehighGap3b.SetActive(true);
        LehighGap3aHid.SetActive(false);
        LehighGap3bHid.SetActive(false);
    }

    public void WALNUTreloaded()
    {
        //FRANCISreloaded();
        //ROCKPORTreloaded();
        LGNCreloaded();
        Walnutport2a.SetActive(true);
        Walnutport2b.SetActive(true);
        Walnutport2aHid.SetActive(false);
        Walnutport2bHid.SetActive(false);
        Walnutport3.SetActive(true);
        Walnutport3Hid.SetActive(false);
    }

    public void CEMENTreloaded()
    {
        //FRANCISreloaded();
        //ROCKPORTreloaded();
        //LGNCreloaded();
        WALNUTreloaded();
        Cementon1a.SetActive(true);
        Cementon1aHid.SetActive(false);
        Cementon1b.SetActive(true);        
        Cementon1bHid.SetActive(false);
        
    }

    public void THOMASreloaded()
    {
        //FRANCISreloaded();
        //ROCKPORTreloaded();
        //LGNCreloaded();
        //WALNUTreloaded();
        CEMENTreloaded();
        Thomas1a.SetActive(true);
        Thomas1aHid.SetActive(false);
        Thomas1b.SetActive(true);
        Thomas1bHid.SetActive(false);

    }

    public void HAMILTONreloaded()
    {
        //FRANCISreloaded();
        //ROCKPORTreloaded();
        //LGNCreloaded();
        //WALNUTreloaded();
        //CEMENTreloaded();
        THOMASreloaded();
        Hamilton1a.SetActive(true);
        Hamilton1aHid.SetActive(false);
        Hamilton1b.SetActive(true);
        Hamilton1bHid.SetActive(false);
        Hamilton1c.SetActive(true);
        Hamilton1cHid.SetActive(false);
    }

    public void BETHLEHEMreloaded()
    {
        //FRANCISreloaded();
        //ROCKPORTreloaded();
        //LGNCreloaded();
        //WALNUTreloaded();
        //CEMENTreloaded();
        //THOMASreloaded();
        HAMILTONreloaded();
        Bethlehem1.SetActive(true);
        Bethlehem1Hid.SetActive(false);
        Bethlehem2.SetActive(true);
        Bethlehem2Hid.SetActive(false);
        Bethlehem3.SetActive(true);
        Bethlehem3Hid.SetActive(false);
    }

    public void EASTONreloaded()
    {
        //FRANCISreloaded();
        //ROCKPORTreloaded();
        //LGNCreloaded();
        //WALNUTreloaded();
        //CEMENTreloaded();
        //THOMASreloaded();
        //HAMILTONreloaded();
        BETHLEHEMreloaded();
        Easton1.SetActive(true);
        Easton1Hid.SetActive(false);
        Easton2.SetActive(true);
        Easton2Hid.SetActive(false);
        Easton3.SetActive(true);
        Easton3Hid.SetActive(false);
    }

    #endregion

    public void activateHIDDEN() // activate the ? ? ? ?  for each journal entry
    {
        Francis1Hid.SetActive(true);
        Francis2aHid.SetActive(true);
        Francis2bHid.SetActive(true);

        Rockport1Hid.SetActive(true);
        Rockport2aHid.SetActive(true);
        Rockport2bHid.SetActive(true);

        LehighGap1Hid.SetActive(true);
        LehighGap2Hid.SetActive(true);
        LehighGap3aHid.SetActive(true);
        LehighGap3bHid.SetActive(true);

        Walnutport2aHid.SetActive(true);
        Walnutport2bHid.SetActive(true);
        Walnutport3Hid.SetActive(true);
    
        Cementon1aHid.SetActive(true);
        Cementon1bHid.SetActive(true);

        Hamilton1aHid.SetActive(true);
        Hamilton1bHid.SetActive(true);
        Hamilton1cHid.SetActive(true);

        Thomas1aHid.SetActive(true);
        Thomas1bHid.SetActive(true);
        
        Bethlehem1Hid.SetActive(true);
        Bethlehem2Hid.SetActive(true);
        Bethlehem3Hid.SetActive(true);

        Easton1Hid.SetActive(true);
        Easton2Hid.SetActive(true);
        Easton3Hid.SetActive(true);
    }

    public void hideENTRIES()
    {
        Francis1.SetActive(false);
        Francis2a.SetActive(false);
        Francis2b.SetActive(false);

        Rockport1.SetActive(false);
        Rockport2a.SetActive(false);
        Rockport2b.SetActive(false);

        LehighGap1.SetActive(false);
        LehighGap2.SetActive(false);
        LehighGap3a.SetActive(false);
        LehighGap3b.SetActive(false);

        Walnutport2a.SetActive(false);
        Walnutport2b.SetActive(false);
        Walnutport3.SetActive(false);

        Cementon1a.SetActive(false);
        Cementon1b.SetActive(false);

        Hamilton1a.SetActive(false);
        Hamilton1b.SetActive(false);
        Hamilton1c.SetActive(false);

        Thomas1a.SetActive(false);
        Thomas1b.SetActive(false);
        
        Bethlehem1.SetActive(false);
        Bethlehem2.SetActive(false);
        Bethlehem3.SetActive(false);

        Easton1.SetActive(false);
        Easton2.SetActive(false);
        Easton3.SetActive(false);
    }

    public void resetJournalPages()
    {
        JournalLogo.SetActive(true);
        FrancisJournal.SetActive(false);
        RockportJournal.SetActive(false);
        LehighGapJournal.SetActive(false);
        WalnutportJournal.SetActive(false);
        CementonJournal.SetActive(false);
        ThomasIronJournal.SetActive(false);
        AllentownJournal.SetActive(false);
        BethlehemJournal.SetActive(false);
        EastonJournal.SetActive(false);
    }    
}