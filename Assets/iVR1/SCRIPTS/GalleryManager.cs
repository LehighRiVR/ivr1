using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GalleryManager : MonoBehaviour
{
    #region DECLARED GAMEOBJECTS
        
    [Header("PAGES")]
    public GameObject FrancisGallery;
    public GameObject RockportGallery;
    public GameObject LehighGapGallery;
    public GameObject WalnutportGallery;
    public GameObject CementonGallery;
    public GameObject ThomasIronGallery;
    public GameObject AllentownGallery;
    public GameObject BethlehemGallery;
    public GameObject EastonGallery;

    [Header("ENTRIES")]

    public GameObject Flyby1;
    public GameObject Flyby2;
    public GameObject Flyby3;
    public GameObject Flyby4;
    public GameObject Flyby5;
    public GameObject Flyby6;
    public GameObject Flyby7;
    public GameObject Flyby8;
    public GameObject Flyby9;
    public GameObject Flyby10;

    public GameObject Francis1;//1a
    public GameObject Francis2;//1b
    public GameObject Francis3;//1c
    public GameObject Francis4;//2a
    public GameObject Francis5;//2b
    public GameObject Francis6;//2c
    public GameObject Francis7;//2d

    public GameObject Rockport1;//1a
    public GameObject Rockport2;//1b
    public GameObject Rockport3;//1c

    public GameObject LehighGap1;//1a
    public GameObject LehighGap2;//1b
    public GameObject LehighGap3;//1c
    public GameObject LehighGap4;//2a
    public GameObject LehighGap5;//2b
    public GameObject LehighGap6;//2c
    public GameObject LehighGap7;//3a
    public GameObject LehighGap8;//3b

    public GameObject Walnutport1;//2a
    public GameObject Walnutport2;//2b
    public GameObject Walnutport3;//2c
    public GameObject Walnutport4;//3a
    public GameObject Walnutport5;//3b
    public GameObject Walnutport6;//3c
    public GameObject Walnutport7;

    public GameObject Cementon1;//1a
    public GameObject Cementon2;//1b
    public GameObject Cementon3;//1c
    public GameObject Cementon4;

    public GameObject Thomas1;//1a
    public GameObject Thomas2;//1b
    public GameObject Thomas3;//1c
    public GameObject Thomas4;
    public GameObject Thomas5;
    public GameObject Thomas6;

    public GameObject Hamilton1;//1a
    public GameObject Hamilton2;//1b
    public GameObject Hamilton3;//1c
    
    public GameObject Bethlehem1;//1a
    public GameObject Bethlehem2;//1b
    public GameObject Bethlehem3;//1c
    public GameObject Bethlehem4;//2a
    public GameObject Bethlehem5;//2b
    public GameObject Bethlehem6;//2c
    public GameObject Bethlehem7;//3a
    
    public GameObject Easton1;//1a
    public GameObject Easton2;//1b
    public GameObject Easton3;//1c
    public GameObject Easton4;//2a
    public GameObject Easton5;//2b
    public GameObject Easton6;//2c
    public GameObject Easton7;//3a

    [Header("???")]

    public GameObject FlybyHid1;
    public GameObject FlybyHid2;
    public GameObject FlybyHid3;
    public GameObject FlybyHid4;
    public GameObject FlybyHid5;
    public GameObject FlybyHid6;
    public GameObject FlybyHid7;
    public GameObject FlybyHid8;
    public GameObject FlybyHid9;
    public GameObject FlybyHid10;

    public GameObject Francis1Hid;
    public GameObject Francis2Hid;
    public GameObject Francis3Hid;
    public GameObject Francis4Hid;
    public GameObject Francis5Hid;
    public GameObject Francis6Hid;
    public GameObject Francis7Hid;

    public GameObject Rockport1Hid;
    public GameObject Rockport2Hid;
    public GameObject Rockport3Hid;
    
    public GameObject LehighGap1Hid;
    public GameObject LehighGap2Hid;
    public GameObject LehighGap3Hid;
    public GameObject LehighGap4Hid;
    public GameObject LehighGap5Hid;
    public GameObject LehighGap6Hid;
    public GameObject LehighGap7Hid;
    public GameObject LehighGap8Hid;
    
    public GameObject Walnutport1Hid;
    public GameObject Walnutport2Hid;
    public GameObject Walnutport3Hid;
    public GameObject Walnutport4Hid;
    public GameObject Walnutport5Hid;
    public GameObject Walnutport6Hid;
    public GameObject Walnutport7Hid;

    public GameObject Cementon1Hid;
    public GameObject Cementon2Hid;
    public GameObject Cementon3Hid;
    public GameObject Cementon4Hid;

    public GameObject Thomas1Hid;
    public GameObject Thomas2Hid;
    public GameObject Thomas3Hid;
    public GameObject Thomas4Hid;
    public GameObject Thomas5Hid;
    public GameObject Thomas6Hid;

    public GameObject Hamilton1Hid;
    public GameObject Hamilton2Hid;
    public GameObject Hamilton3Hid;
       
    public GameObject Bethlehem1Hid;
    public GameObject Bethlehem2Hid;
    public GameObject Bethlehem3Hid;
    public GameObject Bethlehem4Hid;
    public GameObject Bethlehem5Hid;
    public GameObject Bethlehem6Hid;
    public GameObject Bethlehem7Hid;
    
    public GameObject Easton1Hid;
    public GameObject Easton2Hid;
    public GameObject Easton3Hid;
    public GameObject Easton4Hid;
    public GameObject Easton5Hid;
    public GameObject Easton6Hid;
    public GameObject Easton7Hid;

    [Header("EXTRA")]
    public GameObject Francis8;
    public GameObject Francis9;
    public GameObject Francis10;

    public GameObject Rockport4;
    public GameObject Rockport5;
    public GameObject Rockport6;
    public GameObject Rockport7;
    public GameObject Rockport8;
    public GameObject Rockport9;
    public GameObject Rockport10;

    public GameObject LehighGap9;
    public GameObject LehighGap10;

    public GameObject Walnutport8;
    public GameObject Walnutport9;
    public GameObject Walnutport10;

    public GameObject Cementon5;
    public GameObject Cementon6;
    public GameObject Cementon7;
    public GameObject Cementon8;
    public GameObject Cementon9;
    public GameObject Cementon10;

    public GameObject Thomas7;
    public GameObject Thomas8;
    public GameObject Thomas9;
    public GameObject Thomas10;

    public GameObject Hamilton4;
    public GameObject Hamilton5;
    public GameObject Hamilton6;
    public GameObject Hamilton7;
    public GameObject Hamilton8;
    public GameObject Hamilton9;
    public GameObject Hamilton10;

    public GameObject Bethlehem8;
    public GameObject Bethlehem9;
    public GameObject Bethlehem10;

    public GameObject Easton8;
    public GameObject Easton9;
    public GameObject Easton10;
    
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        resetGalleryPages();
        activateHIDDENmedia();
        hideMEDIA();
        removeEXTRA();       

        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        //Debug.Log(currentScene.name);

        if (sceneName == "FRANCISW1" | sceneName == "FRANCISW1B")
        {
            Francis1.SetActive(true);
                Francis1Hid.SetActive(false);
            
            
        }

        if (sceneName == "FRANCISW2" | sceneName == "FRANCISW2B")
        {
            galleryFRANCISreloaded();

            
        }

        if (sceneName == "ROCKPORT1")
        {
            galleryFRANCISreloaded();

            Rockport1.SetActive(true);
            
            Rockport1Hid.SetActive(false);
                        
        }

        if (sceneName == "ROCKPORT2")
        {
            galleryROCKPORTreloaded();
           
            
        }

        if (sceneName == "LGNC1")
        {
            galleryROCKPORTreloaded();

            LehighGap1.SetActive(true);
            LehighGap2.SetActive(true);
            LehighGap3.SetActive(true);
                LehighGap1Hid.SetActive(false);
                LehighGap2Hid.SetActive(false);
                LehighGap3Hid.SetActive(false);

            
        }

        if (sceneName == "LGNC2")
        {
            galleryROCKPORTreloaded();

            LehighGap1.SetActive(true);
            LehighGap2.SetActive(true);
            LehighGap3.SetActive(true);
            LehighGap4.SetActive(true);
            LehighGap5.SetActive(true);
                LehighGap1Hid.SetActive(false);
                LehighGap2Hid.SetActive(false);
                LehighGap3Hid.SetActive(false);
                LehighGap4Hid.SetActive(false);
                LehighGap5Hid.SetActive(false);
            
            
        }

        if (sceneName == "LGNC3")
        {
            galleryLGNCreloaded();

            
        }

        if (sceneName == "WALNUTPORT1")
        {
            galleryLGNCreloaded();

            Walnutport1.SetActive(true);
                Walnutport1Hid.SetActive(false);

            
        }

        if (sceneName == "WALNUTPORT2")
        {
            galleryLGNCreloaded();

            Walnutport1.SetActive(true);
            Walnutport2.SetActive(true);
            Walnutport3.SetActive(true);
                Walnutport1Hid.SetActive(false);
                Walnutport2Hid.SetActive(false);
                Walnutport3Hid.SetActive(false);

            
        }

        if (sceneName == "WALNUTPORT3")
        {
            galleryWALNUTreloaded();

            
        }

        if (sceneName == "CEMENTON")
        {
            galleryCEMENTreloaded();

            
        }

        if (sceneName == "THOMASIRON")
        {
            galleryTHOMASreloaded();

            
        }

        if (sceneName == "ALLENTOWN")
        {
            galleryHAMILTONreloaded();

            
        }

        if (sceneName == "BETHLEHEM1")
        {
            galleryHAMILTONreloaded();

            Bethlehem1.SetActive(true);
            Bethlehem2.SetActive(true);
                Bethlehem1Hid.SetActive(false);
                Bethlehem2Hid.SetActive(false);

            
        }

        if (sceneName == "BETHLEHEM2")
        {
            galleryHAMILTONreloaded();

            Bethlehem1.SetActive(true);
            Bethlehem2.SetActive(true);
            Bethlehem3.SetActive(true);
            Bethlehem4.SetActive(true);
            Bethlehem5.SetActive(true);
                Bethlehem1Hid.SetActive(false);
                Bethlehem2Hid.SetActive(false);
                Bethlehem3Hid.SetActive(false);
                Bethlehem4Hid.SetActive(false);
                Bethlehem5Hid.SetActive(false);

            
        }

        if (sceneName == "BETHLEHEM3")
        {
            galleryBETHLEHEMreloaded();

            
        }

        if (sceneName == "EASTON1")
        {
            galleryBETHLEHEMreloaded();

            Easton1.SetActive(true);
            Easton2.SetActive(true);
                Easton1Hid.SetActive(false);
                Easton2Hid.SetActive(false);
        }

        if (sceneName == "EASTON2")
        {
            galleryBETHLEHEMreloaded();

            Easton1.SetActive(true);
            Easton2.SetActive(true);
            Easton3.SetActive(true);
            Easton4.SetActive(true);
                Easton1Hid.SetActive(false);
                Easton2Hid.SetActive(false);
                Easton3Hid.SetActive(false);
                Easton4Hid.SetActive(false);
        }

        if (sceneName == "EASTON3" || sceneName == "EndMeetingPoint" || sceneName == "360player" || sceneName == "POSTtest")
        {
            galleryEASTONreloaded();
        }

    }
       

    #region RELOADING SCENES

    public void galleryFRANCISreloaded()
    {
        Francis1.SetActive(true);
        Francis2.SetActive(true);
        Francis3.SetActive(true);
        Francis4.SetActive(true);
        Francis5.SetActive(true);
        Francis6.SetActive(true);
        Francis7.SetActive(true);
            Francis1Hid.SetActive(false);
            Francis2Hid.SetActive(false);
            Francis3Hid.SetActive(false);
            Francis4Hid.SetActive(false);
            Francis5Hid.SetActive(false);
            Francis6Hid.SetActive(false);
            Francis7Hid.SetActive(false);
    }

    public void galleryROCKPORTreloaded()
    {
        galleryFRANCISreloaded();
        Rockport1.SetActive(true);
        Rockport2.SetActive(true);
        Rockport3.SetActive(true);
            Rockport1Hid.SetActive(false);
            Rockport2Hid.SetActive(false);
            Rockport3Hid.SetActive(false);
    }

    public void galleryLGNCreloaded()
    {        
        galleryROCKPORTreloaded();
        LehighGap1.SetActive(true);
        LehighGap2.SetActive(true);
        LehighGap3.SetActive(true);
        LehighGap4.SetActive(true);
        LehighGap5.SetActive(true);
        LehighGap6.SetActive(true);
        LehighGap7.SetActive(true);
        LehighGap8.SetActive(true);
            LehighGap1Hid.SetActive(false);
            LehighGap2Hid.SetActive(false);
            LehighGap3Hid.SetActive(false);
            LehighGap4Hid.SetActive(false);
            LehighGap5Hid.SetActive(false);
            LehighGap6Hid.SetActive(false);
            LehighGap7Hid.SetActive(false);
            LehighGap8Hid.SetActive(false);
    }

    public void galleryWALNUTreloaded()
    {        
        galleryLGNCreloaded();
        Walnutport1.SetActive(true);
        Walnutport2.SetActive(true);
        Walnutport3.SetActive(true);
        Walnutport4.SetActive(true);
        Walnutport5.SetActive(true);
        Walnutport6.SetActive(true);
        Walnutport7.SetActive(true);
            Walnutport1Hid.SetActive(false);
            Walnutport2Hid.SetActive(false);
            Walnutport3Hid.SetActive(false);
            Walnutport4Hid.SetActive(false);
            Walnutport5Hid.SetActive(false);
            Walnutport6Hid.SetActive(false);
            Walnutport7Hid.SetActive(false);
    }

    public void galleryCEMENTreloaded()
    {
        galleryWALNUTreloaded();
        Cementon1.SetActive(true);
        Cementon2.SetActive(true);
        Cementon3.SetActive(true);
        Cementon4.SetActive(true);
            Cementon1Hid.SetActive(false);
            Cementon2Hid.SetActive(false);
            Cementon3Hid.SetActive(false);
            Cementon4Hid.SetActive(false);
    }

    public void galleryTHOMASreloaded()
    {
        galleryCEMENTreloaded();
        Thomas1.SetActive(true);
        Thomas2.SetActive(true);
        Thomas3.SetActive(true);
        Thomas4.SetActive(true);
        Thomas5.SetActive(true);
        Thomas6.SetActive(true);
            Thomas1Hid.SetActive(false);
            Thomas2Hid.SetActive(false);
            Thomas3Hid.SetActive(false);
            Thomas4Hid.SetActive(false);
            Thomas5Hid.SetActive(false);
            Thomas6Hid.SetActive(false);
    }

    public void galleryHAMILTONreloaded()
    {
        galleryTHOMASreloaded();
        Hamilton1.SetActive(true);
        Hamilton2.SetActive(true);
        Hamilton3.SetActive(true);
            Hamilton1Hid.SetActive(false);
            Hamilton2Hid.SetActive(false);
            Hamilton3Hid.SetActive(false);
    }

    public void galleryBETHLEHEMreloaded()
    {
        galleryHAMILTONreloaded();

        Bethlehem1.SetActive(true);
        Bethlehem2.SetActive(true);
        Bethlehem3.SetActive(true);
        Bethlehem4.SetActive(true);
        Bethlehem5.SetActive(true);
        Bethlehem6.SetActive(true);
        Bethlehem7.SetActive(true);
            Bethlehem1Hid.SetActive(false);
            Bethlehem2Hid.SetActive(false);
            Bethlehem3Hid.SetActive(false);
            Bethlehem4Hid.SetActive(false);
            Bethlehem5Hid.SetActive(false);
            Bethlehem6Hid.SetActive(false);
            Bethlehem7Hid.SetActive(false);
    }

    public void galleryEASTONreloaded()
    {
        galleryBETHLEHEMreloaded();

        Easton1.SetActive(true);
        Easton2.SetActive(true);
        Easton3.SetActive(true);
        Easton4.SetActive(true);
        Easton5.SetActive(true);
        Easton6.SetActive(true);
        Easton7.SetActive(true);
            Easton1Hid.SetActive(false);
            Easton2Hid.SetActive(false);
            Easton3Hid.SetActive(false);
            Easton4Hid.SetActive(false);
            Easton5Hid.SetActive(false);
            Easton6Hid.SetActive(false);
            Easton7Hid.SetActive(false);
    }

    #endregion

    public void activateHIDDENmedia() // activate the ? ? ? ?  for each gallery entry
    {
        Francis1Hid.SetActive(true);
        Francis2Hid.SetActive(true);
        Francis3Hid.SetActive(true);
        Francis4Hid.SetActive(true);
        Francis5Hid.SetActive(true);
        Francis6Hid.SetActive(true);
        Francis7Hid.SetActive(true);

        Rockport1Hid.SetActive(true);
        Rockport2Hid.SetActive(true);
        Rockport3Hid.SetActive(true);

        LehighGap1Hid.SetActive(true);
        LehighGap2Hid.SetActive(true);
        LehighGap3Hid.SetActive(true);
        LehighGap4Hid.SetActive(true);
        LehighGap5Hid.SetActive(true);
        LehighGap6Hid.SetActive(true);
        LehighGap7Hid.SetActive(true);
        LehighGap8Hid.SetActive(true);
        
        Walnutport1Hid.SetActive(true);
        Walnutport2Hid.SetActive(true);
        Walnutport3Hid.SetActive(true);
        Walnutport4Hid.SetActive(true);
        Walnutport5Hid.SetActive(true);
        Walnutport6Hid.SetActive(true);
        Walnutport7Hid.SetActive(true);

        Cementon1Hid.SetActive(true);
        Cementon2Hid.SetActive(true);
        Cementon3Hid.SetActive(true);
        Cementon4Hid.SetActive(true);

        Thomas1Hid.SetActive(true);
        Thomas2Hid.SetActive(true);
        Thomas3Hid.SetActive(true);
        Thomas4Hid.SetActive(true);
        Thomas5Hid.SetActive(true);
        Thomas6Hid.SetActive(true);

        Hamilton1Hid.SetActive(true);
        Hamilton2Hid.SetActive(true);
        Hamilton3Hid.SetActive(true);
        
        Bethlehem1Hid.SetActive(true);
        Bethlehem2Hid.SetActive(true);
        Bethlehem3Hid.SetActive(true);
        Bethlehem4Hid.SetActive(true);
        Bethlehem5Hid.SetActive(true);
        Bethlehem6Hid.SetActive(true);
        Bethlehem7Hid.SetActive(true);
 
        Easton1Hid.SetActive(true);
        Easton2Hid.SetActive(true);
        Easton3Hid.SetActive(true);
        Easton4Hid.SetActive(true);
        Easton5Hid.SetActive(true);
        Easton6Hid.SetActive(true);
        Easton7Hid.SetActive(true);

    }

    public void hideMEDIA()
    {
        Francis1.SetActive(true);
        Francis2.SetActive(true);
        Francis3.SetActive(true);
        Francis4.SetActive(true);
        Francis5.SetActive(true);
        Francis6.SetActive(true);
        Francis7.SetActive(true);

        Rockport1.SetActive(true);
        Rockport2.SetActive(true);
        Rockport3.SetActive(true);

        LehighGap1.SetActive(true);
        LehighGap2.SetActive(true);
        LehighGap3.SetActive(true);
        LehighGap4.SetActive(true);
        LehighGap5.SetActive(true);
        LehighGap6.SetActive(true);
        LehighGap7.SetActive(true);
        LehighGap8.SetActive(true);

        Walnutport1.SetActive(true);
        Walnutport2.SetActive(true);
        Walnutport3.SetActive(true);
        Walnutport4.SetActive(true);
        Walnutport5.SetActive(true);
        Walnutport6.SetActive(true);
        Walnutport7.SetActive(true);

        Cementon1.SetActive(true);
        Cementon2.SetActive(true);
        Cementon3.SetActive(true);
        Cementon4.SetActive(true);

        Thomas1.SetActive(true);
        Thomas2.SetActive(true);
        Thomas3.SetActive(true);
        Thomas4.SetActive(true);
        Thomas5.SetActive(true);
        Thomas6.SetActive(true);

        Hamilton1.SetActive(true);
        Hamilton2.SetActive(true);
        Hamilton3.SetActive(true);
               
        Bethlehem1.SetActive(true);
        Bethlehem2.SetActive(true);
        Bethlehem3.SetActive(true);
        Bethlehem4.SetActive(true);
        Bethlehem5.SetActive(true);
        Bethlehem6.SetActive(true);
        Bethlehem7.SetActive(true);
        
        Easton1.SetActive(true);
        Easton2.SetActive(true);
        Easton3.SetActive(true);
        Easton4.SetActive(true);
        Easton5.SetActive(true);
        Easton6.SetActive(true);
        Easton7.SetActive(true);

    }

    public void resetGalleryPages()
    {
        Flyby1.SetActive(true);
        Flyby2.SetActive(true);
        Flyby3.SetActive(true);
        Flyby4.SetActive(true);
        Flyby5.SetActive(true);
        Flyby6.SetActive(true);
        Flyby7.SetActive(true);
        Flyby8.SetActive(true);
        Flyby9.SetActive(true);
        Flyby10.SetActive(true);

        FlybyHid1.SetActive(false);
        FlybyHid2.SetActive(false);
        FlybyHid3.SetActive(false);
        FlybyHid4.SetActive(false);
        FlybyHid5.SetActive(false);
        FlybyHid6.SetActive(false);
        FlybyHid7.SetActive(false);
        FlybyHid8.SetActive(false);
        FlybyHid9.SetActive(false);
        FlybyHid10.SetActive(false);

        FrancisGallery.SetActive(false);
        RockportGallery.SetActive(false);
        LehighGapGallery.SetActive(false);
        WalnutportGallery.SetActive(false);
        CementonGallery.SetActive(false);
        ThomasIronGallery.SetActive(false);
        AllentownGallery.SetActive(false);
        BethlehemGallery.SetActive(false);
        EastonGallery.SetActive(false);
    }

    public void removeEXTRA()
    {
        Francis8.SetActive(false);
        Francis9.SetActive(false);
        Francis10.SetActive(false);

        Rockport4.SetActive(false);
        Rockport5.SetActive(false);
        Rockport6.SetActive(false);
        Rockport7.SetActive(false);
        Rockport8.SetActive(false);
        Rockport9.SetActive(false);
        Rockport10.SetActive(false);

        LehighGap9.SetActive(false);
        LehighGap10.SetActive(false);

        Walnutport8.SetActive(false);
        Walnutport9.SetActive(false);
        Walnutport10.SetActive(false);

        Cementon5.SetActive(false);
        Cementon6.SetActive(false);
        Cementon7.SetActive(false);
        Cementon8.SetActive(false);
        Cementon9.SetActive(false);
        Cementon10.SetActive(false);

        Thomas7.SetActive(false);
        Thomas8.SetActive(false);
        Thomas9.SetActive(false);
        Thomas10.SetActive(false);

        Hamilton4.SetActive(false);
        Hamilton5.SetActive(false);
        Hamilton6.SetActive(false);
        Hamilton7.SetActive(false);
        Hamilton8.SetActive(false);
        Hamilton9.SetActive(false);
        Hamilton10.SetActive(false);

        Bethlehem8.SetActive(false);
        Bethlehem9.SetActive(false);
        Bethlehem10.SetActive(false);

        Easton8.SetActive(false);
        Easton9.SetActive(false);
        Easton10.SetActive(false);
    }      
            
}
