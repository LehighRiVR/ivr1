using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class della1HQ : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;
        
    public TextMeshProUGUI della1textDisplay;
    public GameObject della1continueButton;    
    public GameObject della1closeButton;
    
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
       if(selectedLanguage=="English")
       {
            StartCoroutine(Type(sentencesEN));

            if (della1textDisplay.text == sentencesEN[indexEN] && indexEN <= 3)  // && index <= 4  FIXES the issue of the continue button overlapping with the Close button in the last line
            {
                della1continueButton.SetActive(true);
            }
        }
       else if (selectedLanguage=="Spanish")
       {
            StartCoroutine(Type(sentencesSP));

            if (della1textDisplay.text == sentencesSP[indexSP] && indexSP <= 3)  // && index <= 4  FIXES the issue of the continue button overlapping with the Close button in the last line
            {
                della1continueButton.SetActive(true);
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
            della1textDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            della1textDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        della1continueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                della1textDisplay.text = "";
            }

            if (indexEN == 4)
            {
                della1closeButton.SetActive(true);
                della1continueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                della1textDisplay.text = "";
            }

            if (indexSP == 4)
            {
                della1closeButton.SetActive(true);
                della1continueButton.SetActive(false);
            }
        }               
    }   
}
