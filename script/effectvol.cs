using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class effectvol : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer mixer;

    public void effectvolume(float slidervalue)   {
        mixer.SetFloat("effectvol", Mathf.Log10(slidervalue) * 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
