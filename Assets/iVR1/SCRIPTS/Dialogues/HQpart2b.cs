using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HQpart2b : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;
    
    public TextMeshProUGUI hqPart2btextDisplay;
    public GameObject hqPart2bcontinueButton;
    public GameObject hqPart2bcloseButton;

    public string selectedLanguage;

    void Start()
    {
        DialogueBox = GameObject.Find("DialogueFINAL");

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

            if (hqPart2btextDisplay.text == sentencesEN[indexEN] && indexEN <= 1)
            {
                hqPart2bcontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (hqPart2btextDisplay.text == sentencesSP[indexSP] && indexSP <= 1)
            {
                hqPart2bcontinueButton.SetActive(true);
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
            hqPart2btextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            hqPart2btextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        hqPart2bcontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                hqPart2btextDisplay.text = "";
                
            }

            if (indexEN == 2)
            {
                hqPart2bcloseButton.SetActive(true);
                hqPart2bcontinueButton.SetActive(false);

            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                hqPart2btextDisplay.text = "";
                
            }

            if (indexSP == 2)
            {
                hqPart2bcloseButton.SetActive(true);
                hqPart2bcontinueButton.SetActive(false);
            }
        }
    }
}