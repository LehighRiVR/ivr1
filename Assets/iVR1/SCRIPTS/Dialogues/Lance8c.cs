using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lance8c : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI lance8ctextDisplay;
    public GameObject lance8ccontinueButton;
    public GameObject lance8ccloseButton;
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

            if (lance8ctextDisplay.text == sentencesEN[indexEN] && indexEN <= 1)
            {
                lance8ccontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (lance8ctextDisplay.text == sentencesSP[indexSP] && indexSP <= 1)
            {
                lance8ccontinueButton.SetActive(true);
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
            lance8ctextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            lance8ctextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }


    public void NextSentence()
    {
        lance8ccontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                lance8ctextDisplay.text = "";
            }

            if (indexEN == 2)
            {
                lance8ccloseButton.SetActive(true);
                lance8ccontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                lance8ctextDisplay.text = "";                
            }

            if (indexSP == 2)
            {
                lance8ccloseButton.SetActive(true);
                lance8ccontinueButton.SetActive(false);
            }
        }
    }
}