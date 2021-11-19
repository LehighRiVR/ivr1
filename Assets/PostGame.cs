using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PostGame : MonoBehaviour
{
    //public Button quitGame;

    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.GetInt("ExploreMode");

        if (PlayerPrefs.GetInt("ExploreMode") == 1) //unlocked
        {
            //Debug.Log(PlayerPrefs.GetString("ExploreMode"));
            
        }
        else if (PlayerPrefs.GetInt("ExploreMode") == 0)    //locked
        {
            //Debug.Log(PlayerPrefs.GetString("ExploreMode"));
        }


    }
   
    public void UnlockEXPLORE()
    {
        PlayerPrefs.SetInt("ExploreMode", 1);
        //Debug.Log(PlayerPrefs.GetInt("ExploreMode"));
    }

    public void LockEXPLORE()
    {
        PlayerPrefs.SetInt("ExploreMode", 0);
        //Debug.Log(PlayerPrefs.GetInt("ExploreMode"));
    }

    public void UnloadLOCATION()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "EndMeetingPoint")
        {
            SceneManager.UnloadSceneAsync("EndMeetingPoint", UnloadSceneOptions.None);
        }
    }

    public void Load360player()
    {
        SceneManager.LoadSceneAsync("360player", LoadSceneMode.Additive);
        Invoke("UnloadLOCATION", 0.7f);
    }

    public void closeGame()
    {
        Application.Quit();
    }
       

}
