using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTEST : MonoBehaviour
{
    protected int index;
    protected string[] sentences;
    protected float typingSpeed;
    protected TextMeshProUGUI textDisplay;
    protected GameObject continueButton;
    protected GameObject dialogueBox;
    protected GameObject nameTitle;
    protected GameObject closeButton;
    protected GameObject highlighted;
    protected GameObject background;
    

    private void Start()
    {
        Della1Start();
        StartCoroutine(Type());
    }

    private void Update()
    {
        if (textDisplay.text == sentences[index] && index <= 4)  // && index <= 4  FIXES the issue of the continue button overlapping with the Close button in the last line
        {
            continueButton.SetActive(true);
        }

    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }

        if (index == 5)
        {
            closeButton.SetActive(true);
        }

    }

    private void Della1Start()
    {
        dialogueBox.SetActive(true);
        nameTitle.SetActive(true);
        highlighted.SetActive(true);
        background.SetActive(false);

    }

    private void Della1Finish()
    {
        continueButton.SetActive(false);
        dialogueBox.SetActive(false);
        nameTitle.SetActive(false);
        closeButton.SetActive(false);
        highlighted.SetActive(false);
        background.SetActive(true);
    }

}