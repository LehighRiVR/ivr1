using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlossaryManager : MonoBehaviour
{
    #region DECLARED GAMEOBJECTS

    public GameObject ImageShader;

    [Header("PAGES")]
    public GameObject FrancisGlossary;
    public GameObject RockportGlossary;
    public GameObject LehighGapGlossary;
    public GameObject WalnutportGlossary;
    public GameObject CementonGlossary;
    public GameObject ThomasIronGlossary;
    public GameObject AllentownGlossary;
    public GameObject BethlehemGlossary;
    public GameObject EastonGlossary;

    [Header("ENTRIES")]

    public GameObject Francis1;
    public GameObject Francis2;
    public GameObject Francis3;
    public GameObject Francis4;
    public GameObject Francis5;

    public GameObject Rockport1;
    public GameObject Rockport2;
    public GameObject Rockport3;
    public GameObject Rockport4;
    public GameObject Rockport5;

    public GameObject LehighGap1;
    public GameObject LehighGap2;
    public GameObject LehighGap3;
    public GameObject LehighGap4;
    public GameObject LehighGap5;

    public GameObject Walnutport1;
    public GameObject Walnutport2;
    public GameObject Walnutport3;
    public GameObject Walnutport4;
    public GameObject Walnutport5;

    public GameObject Cementon1;
    public GameObject Cementon2;
    public GameObject Cementon3;
    public GameObject Cementon4;
    public GameObject Cementon5;

    public GameObject Hamilton1;
    public GameObject Hamilton2;
    public GameObject Hamilton3;
    public GameObject Hamilton4;
    public GameObject Hamilton5;

    public GameObject Thomas1;
    public GameObject Thomas2;
    public GameObject Thomas3;
    public GameObject Thomas4;
    public GameObject Thomas5;
    
    public GameObject Bethlehem1;
    public GameObject Bethlehem2;
    public GameObject Bethlehem3;
    public GameObject Bethlehem4;
    public GameObject Bethlehem5;
    
    public GameObject Easton1;
    public GameObject Easton2;
    public GameObject Easton3;
    public GameObject Easton4;
    public GameObject Easton5;
    
    [Header("???")]

    public GameObject Francis1HID;
    public GameObject Francis2HID;
    public GameObject Francis3HID;
    public GameObject Francis4HID;
    public GameObject Francis5HID;

    public GameObject Rockport1HID;
    public GameObject Rockport2HID;
    public GameObject Rockport3HID;
    public GameObject Rockport4HID;
    public GameObject Rockport5HID;

    public GameObject LehighGap1HID;
    public GameObject LehighGap2HID;
    public GameObject LehighGap3HID;
    public GameObject LehighGap4HID;
    public GameObject LehighGap5HID;

    public GameObject Walnutport1HID;
    public GameObject Walnutport2HID;
    public GameObject Walnutport3HID;
    public GameObject Walnutport4HID;
    public GameObject Walnutport5HID;

    public GameObject Cementon1HID;
    public GameObject Cementon2HID;
    public GameObject Cementon3HID;
    public GameObject Cementon4HID;
    public GameObject Cementon5HID;

    public GameObject Hamilton1HID;
    public GameObject Hamilton2HID;
    public GameObject Hamilton3HID;
    public GameObject Hamilton4HID;
    public GameObject Hamilton5HID;

    public GameObject Thomas1HID;
    public GameObject Thomas2HID;
    public GameObject Thomas3HID;
    public GameObject Thomas4HID;
    public GameObject Thomas5HID;

    public GameObject Bethlehem1HID;
    public GameObject Bethlehem2HID;
    public GameObject Bethlehem3HID;
    public GameObject Bethlehem4HID;
    public GameObject Bethlehem5HID;

    public GameObject Easton1HID;
    public GameObject Easton2HID;
    public GameObject Easton3HID;
    public GameObject Easton4HID;
    public GameObject Easton5HID;

    #endregion

    // Start is called before the first frame update
    void Start()
    {        
        activateGlossaryHIDDEN();
        hideGlossaryENTRIES();

        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        //Debug.Log(currentScene.name);

        if (sceneName == "FRANCISW1")
        {
            Francis1.SetActive(true);
            Francis2.SetActive(true);
            Francis3.SetActive(true);
            Francis1HID.SetActive(false);
            Francis2HID.SetActive(false);
            Francis3HID.SetActive(false);
        }

        if (sceneName == "FRANCISW1B")
        {
            Francis1.SetActive(true);
            Francis2.SetActive(true);
            Francis3.SetActive(true);
            Francis1HID.SetActive(false);
            Francis2HID.SetActive(false);
            Francis3HID.SetActive(false);
        }

        if (sceneName == "FRANCISW2")
        {
            FRANCISreloaded();
        }

        if (sceneName == "FRANCISW2B")
        {
            FRANCISreloaded();
        }

        if (sceneName == "ROCKPORT1")
        {
            FRANCISreloaded();
            Rockport1.SetActive(true);
            Rockport2.SetActive(true);
            Rockport3.SetActive(true);
            Rockport1HID.SetActive(false);
            Rockport2HID.SetActive(false);
            Rockport3HID.SetActive(false);
        }

        if (sceneName == "ROCKPORT2")
        {
            ROCKPORTreloaded();
        }

        if (sceneName == "LGNC1")
        {
            ROCKPORTreloaded();

            LehighGap1.SetActive(true);
            LehighGap2.SetActive(true);
            
            LehighGap1HID.SetActive(false);
            LehighGap2HID.SetActive(false);            
        }

        if (sceneName == "LGNC2")
        {
            ROCKPORTreloaded();

            LehighGap1.SetActive(true);
            LehighGap2.SetActive(true);
            LehighGap3.SetActive(true);
            LehighGap4.SetActive(true);

            LehighGap1HID.SetActive(false);
            LehighGap2HID.SetActive(false);
            LehighGap3HID.SetActive(false);
            LehighGap4HID.SetActive(false);
        }

        if (sceneName == "LGNC3")
        {
            LGNCreloaded();           
        }

        if (sceneName == "WALNUTPORT1")
        {
            LGNCreloaded();

            Walnutport1.SetActive(true);
            Walnutport2.SetActive(true);
            Walnutport1HID.SetActive(false);
            Walnutport2HID.SetActive(false);
        }

        if (sceneName == "WALNUTPORT2")
        {
            LGNCreloaded();

            Walnutport1.SetActive(true);
            Walnutport2.SetActive(true);
            Walnutport3.SetActive(true);
            Walnutport4.SetActive(true);
            Walnutport1HID.SetActive(false);
            Walnutport2HID.SetActive(false);
            Walnutport3HID.SetActive(false);
            Walnutport4HID.SetActive(false);
        }

        if (sceneName == "WALNUTPORT3")
        {
            WALNUTreloaded();
        }

        if (sceneName == "CEMENTON")
        {
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
            Bethlehem2.SetActive(true);
            Bethlehem3.SetActive(true);
            Bethlehem1HID.SetActive(false);
            Bethlehem2HID.SetActive(false);
            Bethlehem3HID.SetActive(false);
        }

        if (sceneName == "BETHLEHEM2")
        {
            HAMILTONreloaded();

            Bethlehem1.SetActive(true);
            Bethlehem2.SetActive(true);
            Bethlehem3.SetActive(true);
            Bethlehem4.SetActive(true);
            Bethlehem5.SetActive(true);

            Bethlehem1HID.SetActive(false);
            Bethlehem2HID.SetActive(false);
            Bethlehem3HID.SetActive(false);
            Bethlehem4HID.SetActive(false);
            Bethlehem5HID.SetActive(false);
        }

        if (sceneName == "BETHLEHEM3")
        {
            BETHLEHEMreloaded();

        }

        if (sceneName == "EASTON1")
        {
            BETHLEHEMreloaded();

            Easton1.SetActive(true);
            Easton2.SetActive(true);
            Easton3.SetActive(true);
            Easton1HID.SetActive(false);
            Easton2HID.SetActive(false);
            Easton3HID.SetActive(false);
        }

        if (sceneName == "EASTON2")
        {
            BETHLEHEMreloaded();

            Easton1.SetActive(true);
            Easton2.SetActive(true);
            Easton3.SetActive(true);
            Easton4.SetActive(true);
            Easton5.SetActive(true);
            Easton1HID.SetActive(false);
            Easton2HID.SetActive(false);
            Easton3HID.SetActive(false);
            Easton4HID.SetActive(false);
            Easton5HID.SetActive(false);

        }

        if (sceneName == "EASTON3")
        {
            EASTONreloaded();
        }

        if (sceneName == "EndMeetingPoint")
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
        Francis2.SetActive(true);
        Francis3.SetActive(true);
        Francis4.SetActive(true);
        Francis5.SetActive(true);

        Francis1HID.SetActive(false);
        Francis2HID.SetActive(false);
        Francis3HID.SetActive(false);
        Francis4HID.SetActive(false);
        Francis5HID.SetActive(false);
    }

    public void ROCKPORTreloaded()
    {
        FRANCISreloaded();

        Rockport1.SetActive(true);        
        Rockport2.SetActive(true);
        Rockport3.SetActive(true);
        Rockport4.SetActive(true);
        Rockport5.SetActive(true);

        Rockport1HID.SetActive(false);
        Rockport2HID.SetActive(false);
        Rockport3HID.SetActive(false);
        Rockport4HID.SetActive(false);
        Rockport5HID.SetActive(false);
    }

    public void LGNCreloaded()
    {
        ROCKPORTreloaded();

        LehighGap1.SetActive(true);
        LehighGap2.SetActive(true);
        LehighGap3.SetActive(true);
        LehighGap4.SetActive(true);
        LehighGap5.SetActive(true);

        LehighGap1HID.SetActive(false);
        LehighGap2HID.SetActive(false);
        LehighGap3HID.SetActive(false);
        LehighGap4HID.SetActive(false);
        LehighGap5HID.SetActive(false);
    }

    public void WALNUTreloaded()
    {
        LGNCreloaded();

        Walnutport1.SetActive(true);
        Walnutport2.SetActive(true);
        Walnutport3.SetActive(true);
        Walnutport4.SetActive(true);
        Walnutport5.SetActive(true);
        
        Walnutport1HID.SetActive(false);
        Walnutport2HID.SetActive(false);
        Walnutport3HID.SetActive(false);
        Walnutport4HID.SetActive(false);
        Walnutport5HID.SetActive(false);
    }

    public void CEMENTreloaded()
    {
        WALNUTreloaded();

        Cementon1.SetActive(true);
        Cementon2.SetActive(true);
        Cementon3.SetActive(true);
        Cementon4.SetActive(true);
        Cementon5.SetActive(true);

        Cementon1HID.SetActive(false);        
        Cementon2HID.SetActive(false);
        Cementon3HID.SetActive(false);
        Cementon4HID.SetActive(false);
        Cementon5HID.SetActive(false);
    }

    public void THOMASreloaded()
    {
        CEMENTreloaded();

        Thomas1.SetActive(true);
        Thomas2.SetActive(true);
        Thomas3.SetActive(true);
        Thomas4.SetActive(true);
        Thomas5.SetActive(true);

        Thomas1HID.SetActive(false);        
        Thomas2HID.SetActive(false);
        Thomas3HID.SetActive(false);
        Thomas4HID.SetActive(false);
        Thomas5HID.SetActive(false);
    }

    public void HAMILTONreloaded()
    {
        THOMASreloaded();

        Hamilton1.SetActive(true);
        Hamilton2.SetActive(true);
        Hamilton3.SetActive(true);
        Hamilton4.SetActive(true);
        Hamilton5.SetActive(true);

        Hamilton1HID.SetActive(false);        
        Hamilton2HID.SetActive(false);        
        Hamilton3HID.SetActive(false);
        Hamilton4HID.SetActive(false);
        Hamilton5HID.SetActive(false);
    }

    public void BETHLEHEMreloaded()
    {        
        HAMILTONreloaded();

        Bethlehem1.SetActive(true);        
        Bethlehem2.SetActive(true);
        Bethlehem3.SetActive(true);
        Bethlehem4.SetActive(true);
        Bethlehem5.SetActive(true);

        Bethlehem1HID.SetActive(false);
        Bethlehem2HID.SetActive(false);
        Bethlehem3HID.SetActive(false);
        Bethlehem4HID.SetActive(false);
        Bethlehem5HID.SetActive(false);
    }

    public void EASTONreloaded()
    {        
        BETHLEHEMreloaded();

        Easton1.SetActive(true);
        Easton2.SetActive(true);
        Easton3.SetActive(true);
        Easton4.SetActive(true);
        Easton5.SetActive(true);

        Easton1HID.SetActive(false);
        Easton2HID.SetActive(false);
        Easton3HID.SetActive(false);
        Easton4HID.SetActive(false);
        Easton5HID.SetActive(false);

    }

    #endregion

    public void activateGlossaryHIDDEN() // activate the ? ? ? ?  for each glossary entry
    {
        Francis1HID.SetActive(true);
        Francis2HID.SetActive(true);
        Francis3HID.SetActive(true);
        Francis4HID.SetActive(true);
        Francis5HID.SetActive(true);

        Rockport1HID.SetActive(true);
        Rockport2HID.SetActive(true);
        Rockport3HID.SetActive(true);
        Rockport4HID.SetActive(true);
        Rockport5HID.SetActive(true);

        LehighGap1HID.SetActive(true);
        LehighGap2HID.SetActive(true);
        LehighGap3HID.SetActive(true);
        LehighGap4HID.SetActive(true);
        LehighGap5HID.SetActive(true);

        Walnutport1HID.SetActive(true);
        Walnutport2HID.SetActive(true);
        Walnutport3HID.SetActive(true);
        Walnutport4HID.SetActive(true);
        Walnutport5HID.SetActive(true);

        Cementon1HID.SetActive(true);
        Cementon2HID.SetActive(true);
        Cementon3HID.SetActive(true);
        Cementon4HID.SetActive(true);
        Cementon5HID.SetActive(true);
        
        Hamilton1HID.SetActive(true);
        Hamilton2HID.SetActive(true);
        Hamilton3HID.SetActive(true);
        Hamilton4HID.SetActive(true);
        Hamilton5HID.SetActive(true);

        Thomas1HID.SetActive(true);
        Thomas2HID.SetActive(true);
        Thomas3HID.SetActive(true);
        Thomas4HID.SetActive(true);
        Thomas5HID.SetActive(true);
        
        Bethlehem1HID.SetActive(true);
        Bethlehem2HID.SetActive(true);
        Bethlehem3HID.SetActive(true);
        Bethlehem4HID.SetActive(true);
        Bethlehem5HID.SetActive(true);

        Easton1HID.SetActive(true);
        Easton2HID.SetActive(true);
        Easton3HID.SetActive(true);
        Easton4HID.SetActive(true);
        Easton5HID.SetActive(true);
    }

    public void hideGlossaryENTRIES()
    {
        Francis1.SetActive(false);
        Francis2.SetActive(false);
        Francis3.SetActive(false);
        Francis4.SetActive(false);
        Francis5.SetActive(false);

        Rockport1.SetActive(false);
        Rockport2.SetActive(false);
        Rockport3.SetActive(false);
        Rockport4.SetActive(false);
        Rockport5.SetActive(false);

        LehighGap1.SetActive(false);
        LehighGap2.SetActive(false);
        LehighGap3.SetActive(false);
        LehighGap4.SetActive(false);
        LehighGap5.SetActive(false);

        Walnutport1.SetActive(false);
        Walnutport2.SetActive(false);
        Walnutport3.SetActive(false);
        Walnutport4.SetActive(false);
        Walnutport5.SetActive(false);
        
        Cementon1.SetActive(false);
        Cementon2.SetActive(false);
        Cementon3.SetActive(false);
        Cementon4.SetActive(false);
        Cementon5.SetActive(false);

        Hamilton1.SetActive(false);
        Hamilton2.SetActive(false);
        Hamilton3.SetActive(false);
        Hamilton4.SetActive(false);
        Hamilton5.SetActive(false);

        Thomas1.SetActive(false);
        Thomas2.SetActive(false);
        Thomas3.SetActive(false);
        Thomas4.SetActive(false);
        Thomas5.SetActive(false);
        
        Bethlehem1.SetActive(false);
        Bethlehem2.SetActive(false);
        Bethlehem3.SetActive(false);
        Bethlehem4.SetActive(false);
        Bethlehem5.SetActive(false);

        Easton1.SetActive(false);
        Easton2.SetActive(false);
        Easton3.SetActive(false);
        Easton4.SetActive(false);
        Easton5.SetActive(false);
    }        
}