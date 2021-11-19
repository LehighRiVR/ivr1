using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionTimer : MonoBehaviour
{
    public GameObject narration;
    public bool videoplaying;


    void Awake()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "FRANCISW1" | sceneName == "FRANCISW2")
        {
            Camera.main.GetComponent<LookAround>().enabled = false;
        }
        narration.SetActive(true);
        videoplaying = false;
    }

    void Start()
    {
        //FREEZE CAM
        string sceneName = SceneManager.GetActiveScene().name;
      
        if (sceneName != "FLYBY" && sceneName != "EndMeetingPoint")
        {
            if (narration.activeSelf == true)
            {
                Camera.main.GetComponent<LookAround>().enabled = false;
            }
        }
    }    

    public void SkipFLYBY()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void reloadTUTORIAL()
    {
        SceneManager.LoadSceneAsync(3);
        SceneManager.UnloadSceneAsync("FLYBY", UnloadSceneOptions.None);
    }

    public void LoadNextLOCATION()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        
        if (sceneName == "FRANCISW2B" && videoplaying == true)
        {
            StartCoroutine("Path1");
        }

        if (sceneName == "ROCKPORT2" && videoplaying == true)
        {
            StartCoroutine("Path2");
        }

        if (sceneName == "LGNC3" && videoplaying == true)
        {
            StartCoroutine("Path3");
        }

        if (sceneName == "WALNUTPORT3" && videoplaying == true)
        {
            StartCoroutine("Path4");
        }

        if (sceneName == "CEMENTON" && videoplaying == true)
        {
            StartCoroutine("Path5");
        }

        if (sceneName == "THOMASIRON" && videoplaying == true)
        {
            StartCoroutine("Path6");
        }

        if (sceneName == "ALLENTOWN" && videoplaying == true)
        {
            StartCoroutine("Path7");
        }

        if (sceneName == "BETHLEHEM3" && videoplaying == true)
        {
            StartCoroutine("Path8");
        }

        //Debug.Log(SceneManager.sceneCount);
    }

    public void UnloadLOCATION()
    {
        string sceneName = SceneManager.GetActiveScene().name;

       // if (sceneName == "FLYBY")
       // {
       //     SceneManager.UnloadSceneAsync("FLYBY", UnloadSceneOptions.None);
       // }
        if (sceneName == "FRANCISW2B")
        {
            SceneManager.UnloadSceneAsync("FRANCISW2B", UnloadSceneOptions.None);
        }
        if (sceneName == "ROCKPORT2")
        {
            SceneManager.UnloadSceneAsync("ROCKPORT2", UnloadSceneOptions.None);
        }
        if (sceneName == "LGNC3")
        {
            SceneManager.UnloadSceneAsync("LGNC3", UnloadSceneOptions.None);
        }
        if (sceneName == "WALNUTPORT3")
        {
            SceneManager.UnloadSceneAsync("WALNUTPORT3", UnloadSceneOptions.None);
        }
        if (sceneName == "CEMENTON")
        {
            SceneManager.UnloadSceneAsync("CEMENTON", UnloadSceneOptions.None);
        }
        if (sceneName == "THOMASIRON")
        {
            SceneManager.UnloadSceneAsync("THOMASIRON", UnloadSceneOptions.None);
        }
        if (sceneName == "ALLENTOWN")
        {
            SceneManager.UnloadSceneAsync("ALLENTOWN", UnloadSceneOptions.None);
        }
        if (sceneName == "BETHLEHEM3")
        {
            SceneManager.UnloadSceneAsync("BETHLEHEM3", UnloadSceneOptions.None);
        }
    }

    public void LoadNEXTPhotosphere()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        Invoke("UnloadScene", 0.7f);
    }
    public void UnloadScene()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadPREVIOUSPhotosphere()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 1);
        Invoke("UnloadScene", 0.7f);
    }

    public void VideoPlaying()
    {
        videoplaying = true;
    }

    #region COROUTINES

   

    private IEnumerator Path1() // Francis to Rockport
    {
        yield return new WaitForSeconds(14f); // after 14 seconds
        SceneManager.LoadSceneAsync("ROCKPORT1", LoadSceneMode.Additive);
        Invoke("UnloadLOCATION", 0.6f);
    }

    private IEnumerator Path2() // Rockport to Lehigh Gap
    {
        yield return new WaitForSeconds(14f); // after 14 seconds
        SceneManager.LoadSceneAsync("LGNC1", LoadSceneMode.Additive);
        Invoke("UnloadLOCATION", 0.6f);
    }

    private IEnumerator Path3() // Lehigh Gap to Walnutport
    {
        yield return new WaitForSeconds(13f); // after 13 seconds
        SceneManager.LoadSceneAsync("WALNUTPORT1", LoadSceneMode.Additive);
        Invoke("UnloadLOCATION", 0.8f);
    }

    private IEnumerator Path4() // Walnutport to Cementon
    {
        yield return new WaitForSeconds(13f); // after 13 seconds
        SceneManager.LoadSceneAsync("CEMENTON", LoadSceneMode.Additive);
        Invoke("UnloadLOCATION", 0.6f);
    }

    private IEnumerator Path5() // Cementon to Thomas Iron
    {

        yield return new WaitForSeconds(13f); // after 13 seconds
        SceneManager.LoadSceneAsync("THOMASIRON", LoadSceneMode.Additive);
        Invoke("UnloadLOCATION", 0.6f);
    }

    private IEnumerator Path6() // Thomas Iron to Allentown
    {
        yield return new WaitForSeconds(13f); // after 13 seconds
        SceneManager.LoadSceneAsync("ALLENTOWN", LoadSceneMode.Additive);
        Invoke("UnloadLOCATION", 0.6f);
    }

    private IEnumerator Path7() // Allentown to Bethlehem Steel
    {
        yield return new WaitForSeconds(13f); // after 13 seconds
        SceneManager.LoadSceneAsync("BETHLEHEM1", LoadSceneMode.Additive);
        Invoke("UnloadLOCATION", 0.6f);
    }

    private IEnumerator Path8() // Bethlehem Steel to Easton
    {
        yield return new WaitForSeconds(13f); // after 13 seconds
        SceneManager.LoadSceneAsync("EASTON1", LoadSceneMode.Additive);
        Invoke("UnloadLOCATION", 0.6f);  
    }
    #endregion
}
