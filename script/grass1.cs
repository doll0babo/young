using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass1 : MonoBehaviour
{


    private Animator anim;
    public AudioSource audiosource;
    // Start is called before the first frame update

    private void Awake()
    {
        anim = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "PlayerA")
        {
            Debug.Log("tag");
            anim.SetFloat("grassani", 1f);
            if (!audiosource.isPlaying) {
                audiosource.Play();
            }
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerA")
        {
       
                Debug.Log("tagout");
            anim.SetFloat("grassani", 0f);
        }
    }
}
