using System.Collections;
using UnityEngine;
using UnityEngine.Video;

namespace RickRoll
{
    [RequireComponent(typeof(VideoPlayer))]
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private string _movieFilename;

        private void Start()
        {
            StartCoroutine(PlayMovie(_movieFilename));
        }

        // <summary>
        // Stream the specified video.
        // </summary>
        // <param name="filename">The video file.</param>
        // <returns>Coroutine.</returns>

        private IEnumerator PlayMovie(string filename)
        {
            VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
            if (videoPlayer)
            {
                // It's important that the video is in /Assets/StreamingAssets
                string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, _movieFilename);
            
                //Debug.Log($"About play video: {_movieFilename}");

                videoPlayer.url = videoPath;

                videoPlayer.Play();
                while (videoPlayer.isPlaying)
                {
                    yield return null;
                }

                videoPlayer.Stop();
            }
        }
    }
}
