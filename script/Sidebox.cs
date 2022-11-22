using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidebox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainBox;
    public Rigidbody2D rb;
    public AudioSource pong;
    public bool Dbox;
    int a = 1;
    // Start is called before the first frame update
    void Start()
    {
        Dbox = false;
        pong.playOnAwake = false;
        rb.gravityScale = 0;
        pong = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mainBox.GetComponent<DownBoxtest>().Dbox == true)
        {
            rb.gravityScale = 3;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            if (Input.GetKey(KeyCode.Z))
            {
                rb = GetComponent<Rigidbody2D>();
                rb.mass = 1;
            }
            else
            {
                rb = GetComponent<Rigidbody2D>();
                rb.mass = 100;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("street"))
        {
            if (a == 1)
                pong.Play();
            a++;
        }
    }

}
