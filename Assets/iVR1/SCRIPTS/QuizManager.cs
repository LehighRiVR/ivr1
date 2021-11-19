using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public GameObject question;
    public GameObject correct;
    public GameObject wrong;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public Button back;
    public Button next;
      
    // Start is called before the first frame update
    void Start()
    {
        next.interactable = false;
        back.interactable = true;         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CorrectAnswer()
    {
        next.interactable = true;
        back.interactable = false;

        correct.SetActive(true);
        wrong.SetActive(false);
        question.SetActive(false);

        answerA.GetComponent<Button>().interactable = false;
        answerB.GetComponent<Button>().interactable = false;
        answerC.GetComponent<Button>().interactable = false;

        ResetColor();
    }
    
    public void Awrong()
    {
        wrong.SetActive(true);
        question.SetActive(false);

        next.interactable = false;
        back.interactable = true;

        answerA.GetComponent<Button>().interactable = false;
        
        answerA.GetComponent<Image>().color = new Color32(255, 255, 255, 155);
    }

    public void Bwrong()
    {
        wrong.SetActive(true);
        question.SetActive(false);

        next.interactable = false;
        back.interactable = true;

        answerB.GetComponent<Button>().interactable = false;

        answerB.GetComponent<Image>().color = new Color32(255, 255, 255, 155);
    }

    public void Cwrong()
    {
        wrong.SetActive(true);
        question.SetActive(false);

        next.interactable = false;
        back.interactable = true;

        answerC.GetComponent<Button>().interactable = false;

        answerC.GetComponent<Image>().color = new Color32(255, 255, 255, 155);
    }

    public void ResetColor()
    {
        answerA.GetComponent<Image>().color = new Color32(255, 255, 255, 155);
        answerB.GetComponent<Image>().color = new Color32(255, 255, 255, 155);
        answerC.GetComponent<Image>().color = new Color32(255, 255, 255, 155);
    }
}