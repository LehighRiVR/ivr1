using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LanguageManager : MonoBehaviour
{
    public string selectedLanguage;    

    public GameObject checkEN;
    public GameObject checkSP;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();        

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        //Debug.Log(currentScene.name);

        if (sceneName == "GameMenu")
        {
            SetEnglish();            
        }
        //Debug.Log(PlayerPrefs.GetString("language"));
        
        CHECKLanguage();
        //Debug.Log(selectedLanguage);
    }

    // Update is called once per frame
    void Update()
    {
        if (LocalizationSystem.language == "English")
        {
            selectedLanguage = "English";
            checkMarkEN();
        }
        else if (LocalizationSystem.language == "Spanish")
        {
            selectedLanguage = "Spanish";
            checkMarkSP();
        }
    }

    public void SetSpanish()
    {
        LocalizationSystem.language = "Spanish";
        LocalizationSystem.Init();
        //Debug.Log(LocalizationSystem.language);
        PlayerPrefs.SetString("language", LocalizationSystem.language);
        
    }

    public void checkMarkSP()
    {
        checkEN.SetActive(false);
        checkSP.SetActive(true);
    }

    public void SetEnglish()
    {
        LocalizationSystem.language = "English";
        LocalizationSystem.Init();
        //Debug.Log(LocalizationSystem.language);
        PlayerPrefs.SetString("language", LocalizationSystem.language);
        
    }

    public void checkMarkEN()
    {
        checkEN.SetActive(true);
        checkSP.SetActive(false);
    }

    public void CONFIRMlanguage()
    {
        PlayerPrefs.GetString("language");
        //Debug.Log(PlayerPrefs.GetString("language"));                
    }   

    public void CHECKLanguage()
    {
        if (PlayerPrefs.GetString("language").Equals("English"))
        {
            selectedLanguage = "English";

        }
        else if (PlayerPrefs.GetString("language").Equals("Spanish"))
        {
            selectedLanguage = "Spanish";

        }

        if (selectedLanguage == "English")
        {
            LocalizationSystem.language = "English";
            LocalizationSystem.GetLocalizedValue("English");

        }
        else if (selectedLanguage == "Spanish")
        {
            LocalizationSystem.language = "Spanish";
            LocalizationSystem.GetLocalizedValue("Spanish");

        }
    }

}
