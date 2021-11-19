using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class miraFW1 : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI miraFW1textDisplay;
    public GameObject miraFW1continueButton;
    public GameObject miraFW1Box;
    public GameObject miraFW1closeButton;
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

            if (miraFW1textDisplay.text == sentencesEN[indexEN] && indexEN <= 1)
            {
                miraFW1continueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (miraFW1textDisplay.text == sentencesSP[indexSP] && indexSP <= 1)
            {
                miraFW1continueButton.SetActive(true);
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
            miraFW1textDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            miraFW1textDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        miraFW1continueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                miraFW1textDisplay.text = "";
            }

            if (indexEN == 2)
            {
                miraFW1closeButton.SetActive(true);
                miraFW1continueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                miraFW1textDisplay.text = "";
            }

            if (indexSP == 2)
            {
                miraFW1closeButton.SetActive(true);
                miraFW1continueButton.SetActive(false);
            }
        }
    }
}
