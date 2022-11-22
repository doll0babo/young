using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class budring : MonoBehaviour
{
    private Animator anim;
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerA")
        {
            Debug.Log("budtag");
            anim.SetFloat("bud", 1f);
            if (!audiosource.isPlaying)
            {
                audiosource.Play();
            }
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerA")
        {

            Debug.Log("budout");
            anim.SetFloat("bud", 0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
