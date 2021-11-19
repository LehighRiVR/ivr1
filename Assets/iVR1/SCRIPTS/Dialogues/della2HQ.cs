using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class della2HQ : MonoBehaviour
{
    public string[] sentencesEN;

    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;
    public float typingSpeed;

    [Header("Della2")]
    public TextMeshProUGUI della2textDisplay;
    public GameObject della2continueButton;
    public GameObject della2Box;
    public GameObject della2NameTitle;
    public GameObject della2closeButton;
    public GameObject della2Highlighted;
    public GameObject della2Background;
    public string selectedLanguage;

    void Start()
    {
        //Della2Start();
        if (PlayerPrefs.GetString("language").Equals("English"))
        {
            selectedLanguage = "English";
            StartCoroutine(Type(sentencesEN));
        }
        else if (PlayerPrefs.GetString("language").Equals("Spanish"))
        {
            selectedLanguage = "Spanish";
            StartCoroutine(Type(sentencesSP));
        }
    }

    void Update()
    {
        if (selectedLanguage == "English")
        {
            if (della2textDisplay.text == sentencesEN[indexEN] && indexEN <= 0)  
            {
                della2continueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (della2textDisplay.text == sentencesSP[indexSP] && indexSP <= 0)  
            {
                della2continueButton.SetActive(true);
            }
        }
    }

    IEnumerator Type(string[] language)
    {
        if (selectedLanguage == "English")
        {
            foreach (char letter in language[indexEN].ToCharArray())
            {
                della2textDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            foreach (char letter in language[indexSP].ToCharArray())
            {
                della2textDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
    }

    public void NextSentence()
    {
        della2continueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                della2textDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 1)
            {
                della2closeButton.SetActive(true);
                della2continueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                della2textDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 1)
            {
                della2closeButton.SetActive(true);
                della2continueButton.SetActive(false);
            }
        }
    }

    public void Della2Start()
    {
        della2Box.SetActive(true);
        della2NameTitle.SetActive(true);
        della2Highlighted.SetActive(true);
        della2Background.SetActive(false);
    }

    public void Della2Finish()
    {
        della2continueButton.SetActive(false);
        della2Box.SetActive(false);
        della2NameTitle.SetActive(false);
        della2closeButton.SetActive(false);
        della2Highlighted.SetActive(false);
        della2Background.SetActive(true);
    }

}
