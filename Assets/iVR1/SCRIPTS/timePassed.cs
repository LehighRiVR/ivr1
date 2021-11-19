using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timePassed : MonoBehaviour
{
    public Text gameTimerText;
    //float gameTimer = 0f;

    public static float deltaTime;
    private static float _lastframetime;
    void Start()
    {
        _lastframetime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
         deltaTime = Time.realtimeSinceStartup - _lastframetime;
        _lastframetime = Time.realtimeSinceStartup;

        _lastframetime += Time.deltaTime;

        int seconds = (int)(_lastframetime % 60);
        int minutes = (int)(_lastframetime / 60) % 60;

        string timerString = string.Format("{0:00}min {1:00}sec", minutes, seconds);

        gameTimerText.text = timerString;
    }
}
