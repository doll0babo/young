using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour
{
   public float lan;
   

    // Start is called before the first frame update

    private void Start()
    {
        
    }

    public void FixedUpdate()
    {
          lan = 0f;
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("box"))
        { 
            lan = 0.3f;
            Debug.Log(lan);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       
        lan = 0;
        }
    
}
