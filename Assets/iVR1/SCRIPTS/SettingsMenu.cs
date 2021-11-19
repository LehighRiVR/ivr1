using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public Slider volumeSlider;
    public AudioSource audioSource;

    public void SetVolume (float volume)
    {
        //Debug.Log(volume);
        audioSource.volume = volumeSlider.GetComponent<AudioSource>().volume;
    }

     

}
