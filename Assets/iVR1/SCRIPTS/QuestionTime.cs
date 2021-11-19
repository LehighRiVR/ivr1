using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionTime : MonoBehaviour
{
    public Button video;
    public Button photo;
    public Button infoSign;
    public Button next;

    public GameObject quizButton;
    public GameObject quizPanel;
    public GameObject lenniExplore;
    public GameObject lenniQuestion;
    public GameObject dummy;
    public GameObject closeVideo;

    public CanvasGroup transparency;

    private Scene currentScene;
    public string sceneName;

    void Start()
    {
        quizButton.SetActive(false);
        quizPanel.SetActive(false);
        next.interactable = false;
    }

    public void LenniEXPLORE()
    {
        if (sceneName == "FRANCISW1B" | sceneName == "BETHLEHEM2")
        {
            if (photo.interactable == false && infoSign.interactable == false)
            {
                next.interactable = true;
                lenniExplore.SetActive(true);
            }
        }

        if (sceneName == "ROCKPORT1")
        {
            if (photo.interactable == false)
            {
                next.interactable = true;
                lenniExplore.SetActive(true);
            }
        }

        if (sceneName == "LGNC2" | sceneName == "WALNUTPORT2")
        {
            if (photo.interactable == false && infoSign.interactable == false && video.interactable == false)
            {
                next.interactable = true;
                lenniExplore.SetActive(true);
            }
        }

        if ((sceneName == "LGNC1") || (sceneName == "WALNUTPORT1") || (sceneName == "BETHLEHEM1") || (sceneName == "EASTON1") || (sceneName == "EASTON2"))
        {
            if ((photo.interactable == false) && (video.interactable == false))
            {
                next.interactable = true;
                lenniExplore.SetActive(true);
            }
        }
    }

    public void LenniQUESTION()
    {
        if (sceneName == "FRANCISW2B" | sceneName == "ROCKPORT2" | sceneName == "CEMENTON")
        {
            if (photo.interactable == false && video.interactable == false)
            {
                quizButton.SetActive(true);
                lenniQuestion.SetActive(true);
                transparency.alpha = 1;
            }
        }

        if (sceneName == "LGNC3" | sceneName == "WALNUTPORT3" | sceneName == "BETHLEHEM3" | sceneName == "EASTON3")
        {
            if (photo.interactable == false)
            {
                quizButton.SetActive(true);
                lenniQuestion.SetActive(true);
                transparency.alpha = 1;
            }
        }

        if (sceneName == "THOMASIRON" || sceneName == "ALLENTOWN")
        {
            if (photo.interactable == false && video.interactable == false && infoSign.interactable == false)
            {
                quizButton.SetActive(true);
                lenniQuestion.SetActive(true);
                transparency.alpha = 1;
            }
        }
    }
}