using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadmenu : MonoBehaviour
{
    public AudioSource audios;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        audios = GetComponent<AudioSource>();
        audios.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
