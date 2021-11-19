using UnityEngine;
using UnityEngine.UI;

public class MasterVolumeControl : MonoBehaviour
{
    public Slider vol;
    
    void Start()
    {
        vol = GetComponent<Slider>();
        vol.value = 0.5f;       
    }

    
}
