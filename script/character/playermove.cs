using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    // GameObject player,box;
    public static playermove instance;
    public float speed, v;
    public float jumpPower;
    public Animator anim;
    public Rigidbody2D rb;
    private float horizontalMove;
    public GameObject land;
    int jumpcount;
    bool isjump = false;
    public static float vecMove;
    public AudioSource audiosource;
    [SerializeField] private AudioClip[] Clips;
    int walk, walk2;
    


    private void Start()
    {
        vecMove = 0.6f;
        audiosource = GetComponent<AudioSource>();
       v = speed;
        transform.localScale = new Vector2(vecMove, vecMove);
    }

   
    void Update()
    {
        
        anim.SetFloat("Run", Mathf.Abs(horizontalMove));
  
    //    if (isjump)
    //    {
    //        jumpcount = 1;
    //        if (Input.GetKeyDown(KeyCode.Space)) //점프
    //        {
    //            if (jumpcount == 1)
    //            {
    //                isjump = false;
    //                anim.SetTrigger("Jump");
    //                Invoke(("PlayerJump"), 0.25f);
    //                jumpcount = 0;
                
    //        }
    //    }
    //}
        if (jumpCount.isjump)
        {
            jumpCount.jumpcount = 1;

            if (Input.GetKeyDown(KeyCode.Space)) //점프
            {
                if (jumpCount.jumpcount == 1)
                {
                    jumpCount.isjump = false;
                    anim.SetTrigger("Jump");
                    Invoke(("PlayerJump"), 0.1f);
                    jumpCount.jumpcount = 0;
                  
                }
            }
        }



    }
    private void FixedUpdate()
    { 
        walk = walk2;
        audiosource.clip = Clips[walk];
        PlayerMove();
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
    }

    private void Playerpush()
    {
        throw new NotImplementedException();
    }

    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!audiosource.isPlaying)
            {
                audiosource.Play();
            }
            transform.Translate(Vector2.right * speed);
            transform.localScale = new Vector2(vecMove, vecMove);
            if (GameObject.Find("landing").GetComponentInChildren<Landing>().lan == 0.3f)
            {
   
                anim.SetFloat("lan", 0.3f);
            }
            else if (GameObject.Find("landing").GetComponentInChildren<Landing>().lan == 0)
            {
                anim.SetFloat("lan", 0);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (!audiosource.isPlaying)
            {
                audiosource.Play();
            }
            transform.Translate(-Vector2.right * speed);
            transform.localScale = new Vector2(-vecMove, vecMove);
            if (GameObject.Find("landing").GetComponentInChildren<Landing>().lan == 0.3f)
            {
                anim.SetFloat("lan", 0.3f);
            }
            else if (GameObject.Find("landing").GetComponentInChildren<Landing>().lan == 0)
            {

                anim.SetFloat("lan", 0);
            }
        }
        else audiosource.Stop();
    }

    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "street" || collision.gameObject.tag == "box" || collision.gameObject.tag == "seecol" || collision.gameObject.tag == "bowl" || collision.gameObject.tag == "Untagged")
    //    {
    //        isjump = true;
    //        jumpcount = 1;
    //    }
    //}

    public void OnTriggerStay2D(Collider2D collision)
    {
      
        if (collision.gameObject.tag == "lever")
        {
            if (Input.GetKey(KeyCode.X))
            {
                anim.SetTrigger("pull");
                
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            walk2 = 1;
            speed  = (float)(v - 0.05);
            Debug.Log(walk);
        }
        if (collision.gameObject.tag == "Die")
        {
            anim.SetTrigger("Die");
        }
        {
            //if (collision.gameObject.tag == "lever")
            //{
            //    Debug.Log("pulel");
            //    if (Input.GetKey(KeyCode.W))
            //    {
            //        Debug.Log("pullw");
            //        anim.SetTrigger("pull");
            //    }
            //}
        }
       



    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            walk2 = 0;
            speed = (float)(v + 0.05);
        }
    }
    private void PlayerJump()
    {
           rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }
}



