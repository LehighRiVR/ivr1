using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lance8b : MonoBehaviour
{
    public GameObject DialogueBox;
    
    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;
            
    public TextMeshProUGUI lance8btextDisplay;
    public GameObject lance8bcontinueButton;
    public GameObject lance8bcloseButton;
    public string selectedLanguage;

    void Start()
    {
        DialogueBox = GameObject.Find("DialogueBox");

        DialogueBox.SetActive(false);
              
        if (PlayerPrefs.GetString("language").Equals("English"))
        {
            selectedLanguage = "English";                      
        }
        else if (PlayerPrefs.GetString("language").Equals("Spanish"))
        {
            selectedLanguage = "Spanish";                       
        }

        Invoke("DialogueStart", 1.5f);
    }
    
    void Update()
    {
        if (selectedLanguage == "English")
        {  
            StartCoroutine(Type(sentencesEN));

            if (lance8btextDisplay.text == sentencesEN[indexEN] && indexEN <= 3)
            {
                lance8bcontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (lance8btextDisplay.text == sentencesSP[indexSP] && indexSP <= 3)
            {
                lance8bcontinueButton.SetActive(true);
            }
        }
    }

    void DialogueStart()
    {        
        DialogueBox.SetActive(true);                      
    }

    IEnumerator Type(string[] language)
    {
        if (selectedLanguage == "English")
        {
            lance8btextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            lance8btextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    /*
    IEnumerator Type(string[] language)
    {
        if (selectedLanguage == "English")
        {
            foreach (char letter in language[indexEN].ToCharArray())
            {
                lance8btextDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            foreach (char letter in language[indexSP].ToCharArray())
            {
                lance8btextDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
    }
    */ //Backup of typying effect

    public void NextSentence()
    {
        lance8bcontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                lance8btextDisplay.text = "";                
            }

            if (indexEN == 4)
            {
                lance8bcloseButton.SetActive(true);
                lance8bcontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                lance8btextDisplay.text = "";                
            }

            if (indexSP == 4)
            {
                lance8bcloseButton.SetActive(true);
                lance8bcontinueButton.SetActive(false);
            }
        }
    }
}
