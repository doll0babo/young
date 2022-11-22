using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Gass : MonoBehaviour
{

     public Animator animm;
    
   // public AudioSource audiosource;
    private float timelef = 4.0f;
    private float next = 0.0f;
    SpriteRenderer sr;
    public GameObject go;
 

    // Start is called before the first frame update
    void Start()
    {
        sr = go.GetComponent<SpriteRenderer>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > next)
        {
            next = Time.time + timelef;
            animm.SetBool("gas", true);
         
        }
        else
        {
            animm.SetBool("gas", false);
            
        }

    }

    public void gayes()
    {
       
       sr.enabled = true;
        
    }
    public void gax()
    {
        sr.enabled = false;

    }
}
