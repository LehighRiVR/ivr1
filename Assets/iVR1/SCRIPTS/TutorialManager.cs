using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorial1;
    public GameObject masterButton;
    public GameObject worldspace;
    public GameObject dialogueBox;
    public GameObject avatarImage;
    public GameObject infoSign;
    public GameObject npcName;
    public GameObject npcTitle;
    public GameObject continueButton; 
    public GameObject closeButton;
    public GameObject fakeMasterbutton;   
    public GameObject pointer;    
    public GameObject panelPic;
    public GameObject lookaround;
    public GameObject player;
    
    // might want to group all pictures of the lookaround under one parent game object so we can just set that active when lenni talks about it
    


    // Start is called before the first frame update
    public void Start()
    {
        //npcName.GetComponent<TMPro.TextMeshProUGUI>().text = "Lance";
        //npcTitle.GetComponent<TextLocalizerUI>().key = "lance";
        //avatarImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Lance_default");
        //dialogueBox.GetComponent<TextLocalizerUI>().key = "0001c";

        // make a method for continue button? to change text and images when it's clicked on
        // need to have a way to distinguish multiple "continue" clicks **use switch or if condition based on key in dialoguetext?
        //
        /*
        PlayerPrefs.GetInt("Tutorial");

        if (PlayerPrefs.GetInt("Tutorial") == 0) //not completed
        {
            Debug.Log(PlayerPrefs.GetString("Tutorial"));
            RunTutorial();
            
        }
        else if (PlayerPrefs.GetInt("Tutorial") == 1)    //completed
        {
            Debug.Log(PlayerPrefs.GetString("Tutorial"));
            TutorialNotNeeded();
        }
        */
        tutorial1.SetActive(true);
        dellaTutor1();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    #region PlayerPrefstutorial
    public void TutorialNOTDone()
    {
        PlayerPrefs.SetInt("Tutorial", 0);
        //Debug.Log(PlayerPrefs.GetInt("Tutorial"));
    }

    public void TutorialDONE()
    {
        PlayerPrefs.SetInt("Tutorial", 1);
        Debug.Log(PlayerPrefs.GetInt("Tutorial"));
    }


    public void RunTutorial()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "FRANCISW1")
        {
            tutorial1.SetActive(true);
            SceneManager.UnloadSceneAsync("FLYBY", UnloadSceneOptions.None);
        }

        if (sceneName == "FRANCISW2")
        {
            tutorial1.SetActive(true);
            TutorialDONE();
            SceneManager.UnloadSceneAsync("FRANCISW1", UnloadSceneOptions.None);
        }
    }

    

        public void TutorialNotNeeded()
    {
        GameObject.Find("Tutorial(Francis2)").SetActive(false);
        GameObject.Find("CornerHUD(JUL20)").SetActive(true);
        GameObject.Find("LOCATIONpanel").SetActive(true);
    }
    #endregion

    public void dellaTutor1()
    {
        npcName.GetComponent<TMPro.TextMeshProUGUI>().text = "Della";
        npcTitle.GetComponent<TextLocalizerUI>().key = "della";
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 195);
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 725);
        avatarImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("dELLA");
        panelPic.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 500);
        panelPic.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 275);
        panelPic.GetComponent<RectTransform>().LeanSetLocalPosX(55);
        panelPic.GetComponent<RectTransform>().LeanSetLocalPosY(175);

        pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-600);
        pointer.GetComponent<RectTransform>().LeanSetLocalPosY(-175);
        

        //pointer.GetComponent<RectTransform>().transform.position = new Vector3(-475, 0, 0);
        //pointer.transform.position = transform.position + new Vector3(-500, -200);
        //pointer.transform.Rotate(0, 0, -45);

        //pointer.SetActive(true);
    }

    public void lanceTutor1()
    {
        npcName.GetComponent<TMPro.TextMeshProUGUI>().text = "Lance";
        npcTitle.GetComponent<TextLocalizerUI>().key = "lance";
        avatarImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Lance_default");
        panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("progresspanelSnapshot");
        panelPic.SetActive(true);
        //panelPic.GetComponent<Image>().SetNativeSize();
        panelPic.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 650);
        panelPic.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 275);
        panelPic.GetComponent<RectTransform>().LeanSetLocalPosX(55);
        panelPic.GetComponent<RectTransform>().LeanSetLocalPosY(175);

        pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-565);
        pointer.GetComponent<RectTransform>().LeanSetLocalPosY(-115);

    }

    public void miraTutor1()
    {
        npcName.GetComponent<TMPro.TextMeshProUGUI>().text = "Mira";
        npcTitle.GetComponent<TextLocalizerUI>().key = "mira";

        Invoke("Mira_smile", 0);

        panelPic.GetComponent<Image>().sprite = Resources.Load<Sprite>("ChatLog_snapshot");
        //panelPic.GetComponent<Image>().SetNativeSize();
        panelPic.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 650);
        panelPic.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 275);
        panelPic.GetComponent<RectTransform>().LeanSetLocalPosX(55);
        panelPic.GetComponent<RectTransform>().LeanSetLocalPosY(175);

        pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-515);
        pointer.GetComponent<RectTransform>().LeanSetLocalPosY(-145);

    }

    public void lenniTutor1()
    {
        npcName.GetComponent<TMPro.TextMeshProUGUI>().text = "Lenni";
        npcTitle.GetComponent<TextLocalizerUI>().key = "lenni";
       
        Invoke("Lenni_speaking", 0);

        panelPic.SetActive(false);

        pointer.GetComponent<RectTransform>().LeanSetLocalPosX(-490);
        pointer.GetComponent<RectTransform>().LeanSetLocalPosY(-200);
    }

    public void Mira_smile()
    {
        avatarImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Mira_smile");
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 345);
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 725);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosX(555);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosY(-175);
    }

    public void Mira_speak()
    {
        avatarImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Mira_speak");
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 345);
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 725);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosX(555);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosY(-175);
    }

    public void Lenni_speaking()
    {
        avatarImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Lenni_speaking");
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 345);
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 725);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosX(555);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosY(-175);
    }

    public void Lenni_speak()
    {
        avatarImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Lenni_speak");
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 345);
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 725);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosX(555);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosY(-175);
    }

    public void Lenni_smiling()
    {
        avatarImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Lenni_smiling");
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 345);
        avatarImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 725);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosX(555);
        avatarImage.GetComponent<RectTransform>().LeanSetLocalPosY(-175);
    }

    /*
     * Della
     * Lance
     * Mira_smile
     * Lenni_speaking
     * Lenni_speak
     * Mira_speak
     * Lenni_smiling
     */

}
