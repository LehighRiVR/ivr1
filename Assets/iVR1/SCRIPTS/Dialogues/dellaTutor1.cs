using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dellaTutor1 : MonoBehaviour
{
    public GameObject DialogueBoxTutorial;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public GameObject continueButtonTutorial;
    public GameObject closeButtonTutorial;
    public TextMeshProUGUI textDisplayTutorial;
    public string selectedLanguage;

    public GameObject GaMechanics;

    void Start()
    {
        DialogueBoxTutorial = GameObject.Find("DialogueBox");

        DialogueBoxTutorial.SetActive(false);

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

            if (textDisplayTutorial.text == sentencesEN[indexEN] && indexEN <= 2)
            {
                continueButtonTutorial.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (textDisplayTutorial.text == sentencesSP[indexSP] && indexSP <= 2)
            {
                continueButtonTutorial.SetActive(true);
            }
        }
    }

    void DialogueStart()
    {
        DialogueBoxTutorial.SetActive(true);
    }

    IEnumerator Type(string[] language)
    {
        if (selectedLanguage == "English")
        {
            textDisplayTutorial.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            textDisplayTutorial.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        //continueButtonTutorial.SetActive(false);
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (selectedLanguage == "English")
            {
                if (indexEN < sentencesEN.Length - 1)
                {
                    indexEN++;
                    textDisplayTutorial.text = "";
                    StartCoroutine(Type(sentencesEN));

                    if (indexEN == 1)
                    {
                        //closeButtonTutorial.SetActive(true);
                        //continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().masterButton.SetActive(true);
                    }

                    if (indexEN == 2)
                    {
                        //closeButtonTutorial.SetActive(true);
                        //continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().lanceTutor1();
                        GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().progressButton.SetActive(true);
                    }

                    if (indexEN == 3)
                    {
                        GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("journalPanel2");
                    }

                    if (indexEN == 4)
                    {
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("galleryPanel2");
                    }

                    if (indexEN == 5)
                    {
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("glossaryPanel2");
                    }

                    if (indexEN == 6)
                    {
                        //closeButtonTutorial.SetActive(true);
                        //continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().miraTutor1();
                        GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().convoButton.SetActive(true);

                    }

                    if (indexEN == 7)
                    {
                        //closeButtonTutorial.SetActive(true);
                        //continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().lenniTutor1();
                        GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().locationButton.SetActive(true);

                    }

                    if (indexEN == 9)
                    {
                        //closeButtonTutorial.SetActive(true);
                        //continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().miraTutor1();
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("info_snapshot");
                        GaMechanics.GetComponent<TutorialManager>().panelPic.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-615);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(135);
                        GaMechanics.GetComponent<TutorialManager>().infoSign.GetComponent<Image>().enabled = true;

                    }

                    if (indexEN == 10)
                    {
                        closeButtonTutorial.SetActive(true);
                        continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().lenniTutor1();
                        GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().lookaround.SetActive(true);

                    }

                }
            }
            else if (selectedLanguage == "Spanish")
            {
                    if (indexSP < sentencesSP.Length - 1)
                    {
                        indexSP++;
                        textDisplayTutorial.text = "";
                        StartCoroutine(Type(sentencesSP));

                        if (indexSP == 1)
                        {
                            //closeButtonTutorial.SetActive(true);
                            //continueButtonTutorial.SetActive(false);
                            GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(true);
                            GaMechanics.GetComponent<TutorialManager>().masterButton.SetActive(true);
                        }

                        if (indexSP == 2)
                        {
                            //closeButtonTutorial.SetActive(true);
                            //continueButtonTutorial.SetActive(false);
                            GaMechanics.GetComponent<TutorialManager>().lanceTutor1();
                            GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().progressButton.SetActive(true);
                        }

                        if (indexSP == 3)
                        {
                            GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(false);
                            GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("journalPanel2");
                        }

                        if (indexSP == 4)
                        {
                            GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("galleryPanel2");
                        }

                        if (indexSP == 5)
                        {
                            GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("glossaryPanel2");
                        }

                        if (indexSP == 6)
                        {
                            //closeButtonTutorial.SetActive(true);
                            //continueButtonTutorial.SetActive(false);
                            GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(true);
                            GaMechanics.GetComponent<TutorialManager>().miraTutor1();
                            GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().convoButton.SetActive(true);

                        }

                        if (indexSP == 7)
                        {
                            //closeButtonTutorial.SetActive(true);
                            //continueButtonTutorial.SetActive(false);
                            GaMechanics.GetComponent<TutorialManager>().lenniTutor1();
                            GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().locationButton.SetActive(true);

                        }

                        if (indexSP == 9)
                        {
                            //closeButtonTutorial.SetActive(true);
                            //continueButtonTutorial.SetActive(false);
                            GaMechanics.GetComponent<TutorialManager>().miraTutor1();
                            GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("info_snapshot");
                            GaMechanics.GetComponent<TutorialManager>().panelPic.SetActive(true);
                            GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-615);
                            GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(135);
                            GaMechanics.GetComponent<TutorialManager>().infoSign.GetComponent<Image>().enabled = true;

                        }

                        if (indexSP == 10)
                        {
                            closeButtonTutorial.SetActive(true);
                            continueButtonTutorial.SetActive(false);
                            GaMechanics.GetComponent<TutorialManager>().lenniTutor1();
                            GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(false);

                        }

                    }
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (selectedLanguage == "English")
            {
                if (indexEN < sentencesEN.Length - 1)
                {
                    indexEN++;
                    textDisplayTutorial.text = "";
                    StartCoroutine(Type(sentencesEN));

                    if (indexEN == 1)
                    {
                        GaMechanics.GetComponent<TutorialManager>().lanceTutor1();
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("settingsSnapshot");
                        GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().settingsButton.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-519);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(-277);
                    }

                    if (indexEN == 2)
                    {
                        //closeButtonTutorial.SetActive(true);
                        //continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().miraTutor1();
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-550);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(145);
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("photo_Snapshot");
                        GaMechanics.GetComponent<TutorialManager>().worldspace.SetActive(true);

                    }

                    if (indexEN == 3)
                    {
                        GaMechanics.GetComponent<TutorialManager>().panelPic.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-430);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(85);
                        GaMechanics.GetComponent<TutorialManager>().player.SetActive(true);
                    }

                    if (indexEN == 4)
                    {
                        //closeButtonTutorial.SetActive(true);
                        //continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().player.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().lenniTutor1();
                        GaMechanics.GetComponent<TutorialManager>().panelPic.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-630);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(-130);
                        GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().questionButton.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("tutorial_question");
                        
                    }

                    if (indexEN == 5)
                    {
                        closeButtonTutorial.SetActive(true);
                        continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().panelPic.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(false);

                    }

                }
            }
            else if (selectedLanguage == "Spanish")
            {
                if (indexSP < sentencesSP.Length - 1)
                {
                    indexSP++;
                    textDisplayTutorial.text = "";
                    StartCoroutine(Type(sentencesSP));

                    if (indexSP == 1)
                    {
                        GaMechanics.GetComponent<TutorialManager>().lanceTutor1();
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("settingsSnapshot");
                        GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().settingsButton.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-519);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(-277);
                    }

                    if (indexSP == 2)
                    {
                        //closeButtonTutorial.SetActive(true);
                        //continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().miraTutor1();
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-550);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(145);
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("photo_Snapshot");
                        GaMechanics.GetComponent<TutorialManager>().worldspace.SetActive(true);

                    }

                    if (indexSP == 3)
                    {
                        GaMechanics.GetComponent<TutorialManager>().panelPic.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-430);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(85);
                        GaMechanics.GetComponent<TutorialManager>().player.SetActive(true);
                    }

                    if (indexSP == 4)
                    {
                        //closeButtonTutorial.SetActive(true);
                        //continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().player.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().lenniTutor1();
                        GaMechanics.GetComponent<TutorialManager>().panelPic.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-630);
                        GaMechanics.GetComponent<TutorialManager>().pointer.GetComponent<RectTransform>().LeanSetLocalPosY(-130);
                        GaMechanics.GetComponent<TutorialManager>().masterButton.GetComponent<ButtonToggle>().questionButton.SetActive(true);
                        GaMechanics.GetComponent<TutorialManager>().panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("tutorial_question");

                    }

                    if (indexSP == 5)
                    {
                        closeButtonTutorial.SetActive(true);
                        continueButtonTutorial.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().panelPic.SetActive(false);
                        GaMechanics.GetComponent<TutorialManager>().pointer.SetActive(false);

                    }

                }
            }
        }
    }
}
