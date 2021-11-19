using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lenni1HQ : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;
        
    public TextMeshProUGUI lenni1textDisplay;
    public GameObject lenni1continueButton;
    public GameObject lenni1closeButton;
    
    public string selectedLanguage;


    void Start()
    {  
        DialogueBox = GameObject.Find("DialogueBoxLenni");

        DialogueBox.SetActive(false);

        if (PlayerPrefs.GetString("language").Equals("English"))
        {
            selectedLanguage = "English";
        }
        else if (PlayerPrefs.GetString("language").Equals("Spanish"))
        {
            selectedLanguage = "Spanish";
        }

        Invoke("DialogueStart", 0.5f);
    }
    
    void Update()
    {
        if (selectedLanguage == "English")
        {
            StartCoroutine(Type(sentencesEN));

            if (lenni1textDisplay.text == sentencesEN[indexEN] && indexEN <= 0)
            {
                lenni1continueButton.SetActive(true);
            }
         }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (lenni1textDisplay.text == sentencesSP[indexSP] && indexSP <= 0)
            {
                lenni1continueButton.SetActive(true);
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
            lenni1textDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            lenni1textDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        lenni1continueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                lenni1textDisplay.text = "";
            }

            if (indexEN == 1)
            {
                lenni1closeButton.SetActive(true);
                lenni1continueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                lenni1textDisplay.text = "";
            }

            if (indexSP == 1)
            {
                lenni1closeButton.SetActive(true);
                lenni1continueButton.SetActive(false);
            }
        }
    }   
}

