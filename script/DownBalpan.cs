using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownBalpan : MonoBehaviour
{
    public bool bal,pan;
    public AudioSource audioSource;
    void Start()
    {
        bal = false;
        pan = false;
        audioSource = GetComponent<AudioSource>();
        Debug.Log("balfalse");
        
    }

    private void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerA") || collision.gameObject.CompareTag("PlayerB"))
        {
            
            Debug.Log("baltrue");audioSource.Play();
            bal = true;
            pan = true;
            }
        }
     }
 
  


