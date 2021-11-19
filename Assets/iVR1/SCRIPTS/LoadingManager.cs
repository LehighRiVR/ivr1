using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{ 
    /*
    public GameObject loadingScreen;

     public static LoadingManager instance;

    private void Awake()
    {
        instance = this;

        SceneManager.LoadSceneAsync((int)SceneIndexes.GameMenu, LoadSceneMode.Additive);      
    }

    List<AsyncOperation> scenesLoading = new List<AsyncOperation>();

   

    public void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        Debug.Log(sceneName);

        Debug.Log(SceneManager.sceneCount);

    }

    public bool isDone { get; }

    public void LoadNextScene()
    {
        loadingScreen.SetActive(true);
       SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

        if (isDone)
        {
            loadingScreen.SetActive(false);
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }

        Debug.Log(SceneManager.sceneCount);
       
    }
    
    public void LoadScenes()
    {  
        

        if (SceneManager.GetActiveScene().buildIndex == 0 && SceneManager.GetActiveScene().buildIndex == +1)
        {
            loadingScreen.gameObject.SetActive(true);

            scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.GameMenu));
            scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.StartMeetingPoint, LoadSceneMode.Additive));

            StartCoroutine(GetSceneLoadProgress());
        }
        else if (SceneManager.GetActiveScene().buildIndex == 0 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            loadingScreen.gameObject.SetActive(true);

            scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.StartMeetingPoint));
            scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.FRANCISW1, LoadSceneMode.Additive));

            StartCoroutine(GetSceneLoadProgress());
        }
            
        scenesLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndexes.StartMeetingPoint));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.FRANCISW1, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.FRANCISW2, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.FRANCISW1B, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.FRANCISW2B, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.ROCKPORT1, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.ROCKPORT2, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.LGNC1, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.LGNC2, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.LGNC3, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.WALNUTPORT1, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.WALNUTPORT2, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.WALNUTPORT3, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.CEMENTON, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.THOMASIRON, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.ALLENTOWN, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.BETHLEHEM1, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.BETHLEHEM2, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.BETHLEHEM3, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.EASTON1, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.EASTON2, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.EASTON3, LoadSceneMode.Additive));
        scenesLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndexes.EndMeetingPoint, LoadSceneMode.Additive));
    
 public IEnumerator GetSceneLoadProgress()
 {
     for (int i = 0; i < scenesLoading.Count; i++)
     {
         while (!scenesLoading[i].isDone)
         {
             yield return null;
         }
     }
     loadingScreen.gameObject.SetActive(false);
 } 
} 
*/
}
