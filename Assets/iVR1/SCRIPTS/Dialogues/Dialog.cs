using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject dialogBox;
    public GameObject closeButton;
    public string tutorialName;

    void Start()
    {
        StartCoroutine(Type());
        closeButton.SetActive(false);
        Scene currentScene = SceneManager.GetActiveScene();           // Retrieve the name of this scene.
        string tutorialName = currentScene.name;

    }

    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

        
        if (tutorialName == "FRANCISW1" && index == 2)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "FRANCISW2" && index == 3)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "ROCKPORT1" && index == 3)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "ROCKPORT2" && index == 2)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "LGNC1" && index == 5)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "LGNC2" && index == 1)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "LGNC3" && index == 5)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "WALNUTPORT1" && index == 4)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "WALNUTPORT2" && index == 5)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "WALNUTPORT3" && index == 4)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "CEMENTON" && index == 4)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "THOMASIRON" && index == 5)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "ALLENTOWN" && index == 5)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "BETHLEHEM1" && index == 2)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "BETHLEHEM2" && index == 4)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "BETHLEHEM3" && index == 2)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "EASTON1" && index == 5)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "EASTON2" && index == 5)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "EASTON3" && index == 2)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }


        if (tutorialName == "EndMeetingPoint" && index == 4)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

        if (tutorialName == "EndMeetingPoint2" && index == 2)
        {
            continueButton.SetActive(false);
            closeButton.SetActive(true);
        }

    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

    }
    
 public void NextSentence()
    {
       
        continueButton.SetActive(false);

        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        
            
    }  


}
