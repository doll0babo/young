using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key: MonoBehaviour
{
    public bool state;
    public GameObject key1, key2;
    public AudioSource audioSource;
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        state = false;
        Debug.Log(state);
    }
     public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag( "PlayerA"))
        {
            audioSource.Play();
            state= true;
            Debug.Log(state);
            Destroy(this.key1);
        }
        
        if (collision.gameObject.CompareTag( "PlayerB"))
        {
            audioSource.Play();
            state = true;
            Destroy(this.key2);
        }
       
    }
}      


