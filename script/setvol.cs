using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setvol : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer mixer;

        public void setvolume(float slidervalue) {
        mixer.SetFloat("muvol", Mathf.Log10(slidervalue) * 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
