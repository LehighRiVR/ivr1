using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

[RequireComponent(typeof(VideoPlayer))]
public class LoadSpheres : MonoBehaviour
{
    [SerializeField]
    private string _movieFilename;
    public GameObject foldedMap;
    public GameObject lenniAvatar;

    
    void Start()
    {
        
    }

    private IEnumerator PlayMovie(string filename)
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        if (videoPlayer)
        {
            // It's important that the video is in /Assets/StreamingAssets
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, _movieFilename);

           // Debug.Log($"About play video: {_movieFilename}");

            videoPlayer.url = videoPath;

            videoPlayer.Play();
            while (videoPlayer.isPlaying)
            {
                yield return null;
            }

            videoPlayer.Stop();
        }
    }
    
    public void ExploreFRANCISW2B()
    {
        _movieFilename = "riverview3_er.mp4";
        StartCoroutine(PlayMovie(_movieFilename));
        foldedMap.SetActive(false);
        lenniAvatar.SetActive(false);
    }

    public void ExploreROCKPORT1()
    {
        //map button for rockport1 will switch video url with rockport videosphere
        _movieFilename = "Rockport360.mp4";
        StartCoroutine(PlayMovie(_movieFilename));
        foldedMap.SetActive(false);
        lenniAvatar.SetActive(false);
    }

    public void ExploreLGNC2()
    {
        //map button for rockport1 will switch video url with rockport videosphere
        _movieFilename = "LGNC360.mp4";
        StartCoroutine(PlayMovie(_movieFilename));
        foldedMap.SetActive(false);
        lenniAvatar.SetActive(false);
    }

    public void ExploreWALNUTPORT3()
    {
        //map button for rockport1 will switch video url with rockport videosphere
        _movieFilename = "WALNUTPORT360.mp4";
        StartCoroutine(PlayMovie(_movieFilename));
        foldedMap.SetActive(false);
        lenniAvatar.SetActive(false);
    }

    public void ExploreCEMENTON()
    {
        //map button for rockport1 will switch video url with rockport videosphere
        _movieFilename = "CEMENTON360.mp4";
        StartCoroutine(PlayMovie(_movieFilename));
        foldedMap.SetActive(false);
        lenniAvatar.SetActive(false);
    }

    public void ExploreTHOMASIRON()
    {
        //map button for rockport1 will switch video url with rockport videosphere
        _movieFilename = "THOMASIRON360.mp4";
        StartCoroutine(PlayMovie(_movieFilename));
        foldedMap.SetActive(false);
        lenniAvatar.SetActive(false);
    }

    public void ExploreALLENTOWN()
    {
        //map button for rockport1 will switch video url with rockport videosphere
        _movieFilename = "ALLENTOWN360.mp4";
        StartCoroutine(PlayMovie(_movieFilename));
        foldedMap.SetActive(false);
        lenniAvatar.SetActive(false);
    }

    public void ExploreBETHLEHEM1()
    {
        //map button for rockport1 will switch video url with rockport videosphere
        _movieFilename = "BETHLEHEM360.mp4";
        StartCoroutine(PlayMovie(_movieFilename));
        foldedMap.SetActive(false);
        lenniAvatar.SetActive(false);
    }

    public void ExploreEASTON2()
    {
        //map button for rockport1 will switch video url with rockport videosphere
        _movieFilename = "EASTON360.mp4";
        StartCoroutine(PlayMovie(_movieFilename));
        foldedMap.SetActive(false);
        lenniAvatar.SetActive(false);
    }
}
