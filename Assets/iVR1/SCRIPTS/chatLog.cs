using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class chatLog : MonoBehaviour
{
    public GameObject watershedEN;
    public GameObject watershedSP;
    public GameObject anthraciteEN;
    public GameObject anthraciteSP;
    public GameObject bargeEN;
    public GameObject bargeSP;
    public GameObject furnaceEN;
    public GameObject furnaceSP;
    public GameObject brownfieldsEN;
    public GameObject brownfieldsSP;
    public GameObject confluenceEN;
    public GameObject confluenceSP;
    public GameObject depEN;
    public GameObject depSP;
    public GameObject epaEN;
    public GameObject epaSP;
    public GameObject erodingEN;
    public GameObject erodingSP;
    public GameObject fishladderEN;
    public GameObject fishladderSP;
    public GameObject geoSurveyEN;
    public GameObject geoSurveySP;
    public GameObject groundwaterEN;
    public GameObject groundwaterSP;
    public GameObject landfillEN;
    public GameObject landfillSP;
    public GameObject packetEN;
    public GameObject packetSP;
    public GameObject quarryEN;
    public GameObject quarrySP;
    public GameObject shadEN;
    public GameObject shadSP;
    public GameObject tributaryEN;
    public GameObject tributarySP;
    public GameObject smeltersEN;
    public GameObject smeltersSP;
    public GameObject spawningEN;
    public GameObject spawningSP;
    public GameObject soxEN;
    public GameObject soxSP;
    public GameObject superfundEN;
    public GameObject superfundSP;

    //public string selectedLanguage;

    // Start is called before the first frame update
    void Start()
    {
        // Creates a variable of the type 'Scene' named currentScene.
        // 'SceneManager.GetActiveScene()' stores the name of the active scene into the newly created var
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        
        //Debug.Log(currentScene.name);             
    }

    void Update()
    {
        GameObject.Find("GaMechanics").GetComponent<LanguageManager>().CHECKLanguage();

        if (PlayerPrefs.GetString("language").Equals("English"))
        {
            watershedEN.GetComponent<Image>().enabled = true;
            anthraciteEN.GetComponent<Image>().enabled = true;
            bargeEN.GetComponent<Image>().enabled = true;
            furnaceEN.GetComponent<Image>().enabled = true;
            brownfieldsEN.GetComponent<Image>().enabled = true;
            confluenceEN.GetComponent<Image>().enabled = true;
            depEN.GetComponent<Image>().enabled = true;
            epaEN.GetComponent<Image>().enabled = true;
            erodingEN.GetComponent<Image>().enabled = true;
            fishladderEN.GetComponent<Image>().enabled = true;
            geoSurveyEN.GetComponent<Image>().enabled = true;
            groundwaterEN.GetComponent<Image>().enabled = true;
            landfillEN.GetComponent<Image>().enabled = true;
            packetEN.GetComponent<Image>().enabled = true;
            quarryEN.GetComponent<Image>().enabled = true;
            shadEN.GetComponent<Image>().enabled = true;
            tributaryEN.GetComponent<Image>().enabled = true;
            smeltersEN.GetComponent<Image>().enabled = true;
            spawningEN.GetComponent<Image>().enabled = true;
            soxEN.GetComponent<Image>().enabled = true;
            superfundEN.GetComponent<Image>().enabled = true;

            watershedSP.GetComponent<Image>().enabled = false;
            anthraciteSP.GetComponent<Image>().enabled = false;
            bargeSP.GetComponent<Image>().enabled = false;
            furnaceSP.GetComponent<Image>().enabled = false;
            brownfieldsSP.GetComponent<Image>().enabled = false;
            confluenceSP.GetComponent<Image>().enabled = false;
            depSP.GetComponent<Image>().enabled = false;
            epaSP.GetComponent<Image>().enabled = false;
            erodingSP.GetComponent<Image>().enabled = false;
            fishladderSP.GetComponent<Image>().enabled = false;
            geoSurveySP.GetComponent<Image>().enabled = false;
            groundwaterSP.GetComponent<Image>().enabled = false;
            landfillSP.GetComponent<Image>().enabled = false;
            packetSP.GetComponent<Image>().enabled = false;
            quarrySP.GetComponent<Image>().enabled = false;
            shadSP.GetComponent<Image>().enabled = false;
            tributarySP.GetComponent<Image>().enabled = false;
            smeltersSP.GetComponent<Image>().enabled = false;
            spawningSP.GetComponent<Image>().enabled = false;
            soxSP.GetComponent<Image>().enabled = false;
            superfundSP.GetComponent<Image>().enabled = false;
        }
        else if (PlayerPrefs.GetString("language").Equals("Spanish"))
        {
            watershedSP.GetComponent<Image>().enabled = true;
            anthraciteSP.GetComponent<Image>().enabled = true;
            bargeSP.GetComponent<Image>().enabled = true;
            furnaceSP.GetComponent<Image>().enabled = true;
            brownfieldsSP.GetComponent<Image>().enabled = true;
            confluenceSP.GetComponent<Image>().enabled = true;
            depSP.GetComponent<Image>().enabled = true;
            epaSP.GetComponent<Image>().enabled = true;
            erodingSP.GetComponent<Image>().enabled = true;
            fishladderSP.GetComponent<Image>().enabled = true;
            geoSurveySP.GetComponent<Image>().enabled = true;
            groundwaterSP.GetComponent<Image>().enabled = true;
            landfillSP.GetComponent<Image>().enabled = true;
            packetSP.GetComponent<Image>().enabled = true;
            quarrySP.GetComponent<Image>().enabled = true;
            shadSP.GetComponent<Image>().enabled = true;
            tributarySP.GetComponent<Image>().enabled = true;
            smeltersSP.GetComponent<Image>().enabled = true;
            spawningSP.GetComponent<Image>().enabled = true;
            soxSP.GetComponent<Image>().enabled = true;
            superfundSP.GetComponent<Image>().enabled = true;

            watershedEN.GetComponent<Image>().enabled = false;
            anthraciteEN.GetComponent<Image>().enabled = false;
            bargeEN.GetComponent<Image>().enabled = false;
            furnaceEN.GetComponent<Image>().enabled = false;
            brownfieldsEN.GetComponent<Image>().enabled = false;
            confluenceEN.GetComponent<Image>().enabled = false;
            depEN.GetComponent<Image>().enabled = false;
            epaEN.GetComponent<Image>().enabled = false;
            erodingEN.GetComponent<Image>().enabled = false;
            fishladderEN.GetComponent<Image>().enabled = false;
            geoSurveyEN.GetComponent<Image>().enabled = false;
            groundwaterEN.GetComponent<Image>().enabled = false;
            landfillEN.GetComponent<Image>().enabled = false;
            packetEN.GetComponent<Image>().enabled = false;
            quarryEN.GetComponent<Image>().enabled = false;
            shadEN.GetComponent<Image>().enabled = false;
            tributaryEN.GetComponent<Image>().enabled = false;
            smeltersEN.GetComponent<Image>().enabled = false;
            spawningEN.GetComponent<Image>().enabled = false;
            soxEN.GetComponent<Image>().enabled = false;
            superfundEN.GetComponent<Image>().enabled = false;
        }

    }    
}
