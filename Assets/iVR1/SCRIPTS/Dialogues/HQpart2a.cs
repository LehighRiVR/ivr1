using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HQpart2a : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;
            
    public TextMeshProUGUI hqPart2atextDisplay;
    public GameObject hqPart2acontinueButton;
    public GameObject hqPart2acloseButton;

    public string selectedLanguage;

    void Start()
    {
        DialogueBox = GameObject.Find("DialogueBoxDella");

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

            if (hqPart2atextDisplay.text == sentencesEN[indexEN] && indexEN <= 3)
            {
                hqPart2acontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (hqPart2atextDisplay.text == sentencesSP[indexSP] && indexSP <= 3)
            {
                hqPart2acontinueButton.SetActive(true);
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
            foreach (char letter in language[indexEN].ToCharArray())
            {
                hqPart2atextDisplay.text = language[indexEN].ToString();
                yield return new WaitForSeconds(0);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            foreach (char letter in language[indexSP].ToCharArray())
            {
                hqPart2atextDisplay.text = language[indexSP].ToString();
                yield return new WaitForSeconds(0);
            }
        }
    }

    public void NextSentence()
    {
        hqPart2acontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                hqPart2atextDisplay.text = "";               
            }

            if (indexEN == 4)
            {
                hqPart2acloseButton.SetActive(true);
                hqPart2acontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                hqPart2atextDisplay.text = "";                
            }

            if (indexSP == 4)
            {
                hqPart2acloseButton.SetActive(true);
                hqPart2acontinueButton.SetActive(false);
            }
        }
    }
}