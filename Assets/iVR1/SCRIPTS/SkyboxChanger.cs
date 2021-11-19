using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkyboxChanger : MonoBehaviour
{
    public Material skyboxDefault;
    public Material skyboxVideo;

    public GameObject pauseVideo;
    public GameObject repeatVideo;
    public GameObject closedVideo;
    public GameObject videoPlayer360;
    public GameObject video360Manager;
    //public GameObject Nadir;

    

    // DONT FORGET TO INSERT THESE GAMEOBJECTS INTO THE INSPECTOR
    public GameObject worldCanvas;
    public GameObject compass;
    public GameObject location;

    public Button closeButton;      

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
           
        string sceneName = currentScene.name;

        if (sceneName == "FRANCISW2B")
        {
            closeButton = GameObject.Find("360VIDEObutton(JUL21)").gameObject.GetComponentInChildren<Button>();
        }
    }     

    public void SkyboxSwap()
    {
        RenderSettings.skybox = skyboxVideo;
        worldCanvas.SetActive(false);
        videoPlayer360.SetActive(true);
        video360Manager.SetActive(true);
        compass.SetActive(false);
        location.SetActive(false);
    }

    public void SkyboxReturn()
    {
        RenderSettings.skybox = skyboxDefault;
        worldCanvas.SetActive(true);
        videoPlayer360.SetActive(false);
        video360Manager.SetActive(false);
        compass.SetActive(true);
        location.SetActive(true);
        //Nadir.SetActive(false);

        closeButton.interactable = false;
    }        
}
