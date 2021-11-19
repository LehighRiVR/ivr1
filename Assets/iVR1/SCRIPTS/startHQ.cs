using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startHQ : MonoBehaviour
{
    [Header("AVATAR")]
    public GameObject avatarDella;
    public GameObject avatarDellaBG;
    public GameObject avatarMira;
    public GameObject avatarMiraBG;
    public GameObject avatarLance;
    public GameObject avatarLanceBG;
    public GameObject avatarLenni;
    public GameObject avatarLenniBG;

    [Header("NAME/TITLE")]
    public GameObject nameALL;
    public GameObject nameDella;
    public GameObject nameMira;
    public GameObject nameLance;
    public GameObject nameLenni;

    [Header("DIALOGUE")]
    public GameObject parentDialogue;
    public GameObject dialogueDella;
    public GameObject dialogueMira;
    public GameObject dialogueLance;
    public GameObject dialogueLenni;
    public GameObject dialogueFINAL;

    [Header("CONTINUE")]
    public GameObject continueDella;
    public GameObject continueMira;
    public GameObject continueLance;
    public GameObject continueLenni;

    [Header("CLOSE")]
    public GameObject closeDella;
    public GameObject closeMira;
    public GameObject closeLance;
    public GameObject closeLenni;

    [Header("SCENES")]
    public GameObject selectionPanel;
    public GameObject tablet;
    public GameObject measureWL;
    public GameObject demographicSurvey;
    public GameObject canvasNormal;

    //public GameObject endPanel;

    // Start is called before the first frame update
    void Start()
    {
        SceneStart();
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "StartMeetingPoint")
        {
            DellaHQ1();
        }

        canvasNormal.SetActive(true);
        tablet.SetActive(false);
    }

    public void SceneStart()
    {
        avatarDella.SetActive(true);
        avatarDellaBG.SetActive(false);
        avatarMira.SetActive(false);
        avatarMiraBG.SetActive(false);
        avatarLance.SetActive(false);
        avatarLanceBG.SetActive(false);
        avatarLenni.SetActive(false);
        avatarLenniBG.SetActive(false);
    }

    public void WLstart()
    {        
        canvasNormal.SetActive(false);
        measureWL.SetActive(true);

        avatarDella.SetActive(false);
        avatarDellaBG.SetActive(false);
        avatarMira.SetActive(true);
        avatarMiraBG.SetActive(false);
        avatarLance.SetActive(false);
        avatarLanceBG.SetActive(false);
        avatarLenni.SetActive(false);
        avatarLenniBG.SetActive(false);
        tablet.SetActive(false);
    } 
        

    #region ACTIVATE DIALOGUES

    public void DellaHQ1()
    {
        avatarDella.SetActive(true);
        nameDella.SetActive(true);
        //dialogueDella.SetActive(true); //activated by della1HQ.cs
    }

    public void MiraHQ1()
    {
        avatarMira.SetActive(true);
        nameMira.SetActive(true);
        dialogueMira.SetActive(true);
        tablet.SetActive(true);
    }

    public void MiraHQ2()
    {
        parentDialogue.SetActive(true);
        avatarMira.SetActive(true);
        avatarDellaBG.SetActive(true);
        //avatarLance.SetActive(true);
        //avatarLenni.SetActive(true);
        //avatarDella.SetActive(true);
        selectionPanel.SetActive(false);
        dialogueDella.SetActive(false);
        dialogueMira.SetActive(true);
        closeDella.SetActive(false);
        //dialogueFINAL.SetActive(true);
        //nameALL.SetActive(true);
        nameMira.SetActive(true);
    }
       


    public void LanceHQ1()
    {
        avatarLance.SetActive(true);
        nameLance.SetActive(true);
        dialogueLance.SetActive(true);
    }

    public void LenniHQ1()
    {
        avatarLenni.SetActive(true);
        nameLenni.SetActive(true);
        dialogueLenni.SetActive(true);
    }

    #endregion

    #region DEactivate DIALOGUES

    public void selectionTime()
    {
        if (!selectionPanel.activeSelf)
        {
            parentDialogue.SetActive(false);
            nameDella.SetActive(false);
            avatarDella.SetActive(false);
            selectionPanel.SetActive(true);
        }   
    }
    
    public void lastDialogue()
    {
        parentDialogue.SetActive(true);
        avatarMira.SetActive(true);
        avatarLance.SetActive(true);
        avatarLenni.SetActive(true);
        avatarDella.SetActive(true);
        avatarDellaBG.SetActive(false);
        selectionPanel.SetActive(false);
        dialogueMira.SetActive(false);
        closeDella.SetActive(false);
        dialogueFINAL.SetActive(true);
        nameALL.SetActive(true);
    }

    public void DellaHQ1close()
    {
        string sceneName = SceneManager.GetActiveScene().name;

            avatarDella.SetActive(false);
            avatarDellaBG.SetActive(true);
            nameDella.SetActive(false);
            dialogueDella.SetActive(false);
            closeDella.SetActive(false);        
           /*
            avatarDella.SetActive(false);
            avatarDellaBG.SetActive(false);
            nameDella.SetActive(false);
            dialogueDella.SetActive(false);
            closeDella.SetActive(false);
            */
    }
     
    public void MiraHQ1close()
    {
        WLstart();

        avatarMira.SetActive(false);
        avatarMiraBG.SetActive(true);
        nameMira.SetActive(false);
        dialogueMira.SetActive(false);
        closeMira.SetActive(false);
    }

    public void LanceHQ1close()
    {
        avatarLance.SetActive(false);
        avatarLanceBG.SetActive(true);
        nameLance.SetActive(false);
        dialogueLance.SetActive(false);
        closeLance.SetActive(false);
    }

    public void LenniHQ1close()
    {
        avatarLenni.SetActive(false);
        avatarLenniBG.SetActive(true);
        nameLenni.SetActive(false);
        dialogueLenni.SetActive(false);
        closeLenni.SetActive(false);
    }

    #endregion
}
