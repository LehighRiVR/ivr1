using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public Animation fadeStart;
    public Animation fadeEnd;

    public float transitionTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeIN()
    {

    }

    public void FadeOUT()
    {

    }

    IEnumerator LoadLevel()
    {
        //Play animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);


        //Load Scene
    }
}
