using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimedEvents : MonoBehaviour
{
    public GameObject Line1;
    public GameObject Line2a;
    public GameObject Line2b;
    public GameObject Line3;
    public GameObject Line4;
    public GameObject Line5;
    public GameObject Line6;
    public GameObject Line7;
    public GameObject Line8a;
    public GameObject Line8b;
    public GameObject Line9;
    public GameObject Line10;

    public GameObject narrationPanel;
    public GameObject LehighRiVR;

    //public Text timer;

    //private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        LehighRiVR = GameObject.Find("LehighRiVR_logo");
        string sceneName = SceneManager.GetActiveScene().name;
        
        StartCoroutine("Narration");
        //startTime = Time.time;
        
    }

    private IEnumerator Narration()
    {

        yield return new WaitForSeconds(4.5f); // after 4.5 seconds

        //Show Line1 and activate background panel
        LehighRiVR.GetComponent<Image>().CrossFadeAlpha(0, 1, true);
        narrationPanel.SetActive(true);
        Line1.SetActive(true);
        //Debug.Log("Everyone lives in a watershed.");

        yield return new WaitForSeconds(3.5f); // after 3 seconds
        
        //Hide the previous line and Show Line2a
        Line1.SetActive(false);
        Line2a.SetActive(true);
        //Debug.Log("Our watershed is named the Lehigh River watershed since the Lehigh River flows through it.");

        yield return new WaitForSeconds(7.5f); // after ? seconds

        //Hide the previous line and Show Line2b
        Line2a.SetActive(false);
        Line2b.SetActive(true);
        //Debug.Log("Do you recognize any cities and towns in our watershed?");

        yield return new WaitForSeconds(7.5f); // after ? seconds

        //Hide the previous line and Show Line3
        Line2b.SetActive(false);
        Line3.SetActive(true);
       // Debug.Log("Let’s explore how water flows in our watershed.");

        yield return new WaitForSeconds(5.25f); // after 24 seconds

        //Hide the previous line and Show Line4
        Line3.SetActive(false);
        Line4.SetActive(true);
        //Debug.Log("The Lehigh River begins in wetlands far north of the Lehigh Valley. The high ground surrounding its tributaries form the Lehigh River watershed boundary.");

        yield return new WaitForSeconds(11.75f); // after 31 seconds

        //Hide the previous line and Show Line5
        Line4.SetActive(false);
        Line5.SetActive(true);
        //Debug.Log("From the headwaters, the river flows south to the Francis E. Walter dam, where it is restricted for flood control and recreation.");

        yield return new WaitForSeconds(8.5f); // after 36 seconds

        //Hide the previous line and Show Line6
        Line5.SetActive(false);
        Line6.SetActive(true);
        //Debug.Log("As we travel south along the Lehigh River, we encounter a gap in the Kittatinny Ridge, also known as Blue Mountain.");

        yield return new WaitForSeconds(10.0f); // after 41 seconds

        //Hide the previous line and Show Line7
        Line6.SetActive(false);
        Line7.SetActive(true);
        //Debug.Log("As we continue to travel south down the Lehigh River, notice that many towns and cities were established along the river, often where tributaries join the main stem.");

        yield return new WaitForSeconds(14.0f); // after 49 seconds

        //Hide the previous line and Show Line8a
        Line7.SetActive(false);
        Line8a.SetActive(true);
       // Debug.Log("Just as rivers may feed into one another, watersheds connect. The Lehigh River flows into the Delaware River, so the Lehigh River watershed is nested in the Delaware River watershed.");

        yield return new WaitForSeconds(13.0f); // after 59 seconds

        //Hide the previous line and Show Line8b
        Line8a.SetActive(false);
        Line8b.SetActive(true);
        //Debug.Log("The Delaware River then flows into the Delaware Bay, which empties into the Atlantic Ocean.");

        yield return new WaitForSeconds(6.0f); // after 63 seconds

        //Hide the previous line and Show Line9
        Line8b.SetActive(false);
        Line9.SetActive(true);
        //Debug.Log("The entire east coast of the United States drains into the Atlantic Ocean, through multiple watersheds.");

        yield return new WaitForSeconds(7.0f); // after 69 seconds

        //Hide the previous line and Show Line10
        Line9.SetActive(false);
        Line10.SetActive(true);
        //Debug.Log("In the past, the Lehigh River was used for transporting people and materials to powering factories.  The industrial revolution began in this watershed. Today, the river is used for recreation.");

        yield return new WaitForSeconds(14f); // after 80 seconds,
      
        
        SceneManager.LoadSceneAsync("FRANCISW1", LoadSceneMode.Additive);
        Invoke("UnloadFLYBY", 1.0f);

    }
    
    public void UnloadFLYBY()
    {
        SceneManager.UnloadSceneAsync("FLYBY", UnloadSceneOptions.None);  
    }

    /*
    public void oldTimer()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString();

        timer.text = minutes + ":" + seconds;
    }
    */

}



