using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class playermoveB : MonoBehaviour
{
   // GameObject player,box;
   public static playermoveB instance;
    public float speed,v;
    public float jumpPower;
    public Animator anim;
    public AudioSource audiosource;
    public Rigidbody2D rb;
    private float horizontalMove;
    public GameObject land;
    public static float vecMoveB;
    public bool levrt;
    int jumpcount;
    bool isjump = false;
    bool ispull = false;
    [SerializeField] private AudioClip[] Clips;
    int walk, walk2;

    private void Start()
    {
        jumpcount = 1;
        vecMoveB = 0.6f;
        rb.gravityScale = 3f;
        transform.localScale = new Vector2(vecMoveB, vecMoveB);
        v = speed;
        isjump = true;
    }
  void Update()
    {
        walk = walk2;
        audiosource.clip = Clips[walk];
        PlayerMove();
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        anim.SetFloat("Run", Mathf.Abs(horizontalMove));

          if (horizontalMove==0)
        {
            anim.SetFloat("lan", 0);
        }

        //if (isjump)
        //{
        //    jumpcount = 1;
        //    if (Input.GetKeyDown(KeyCode.Space)) //점프
        //    {
        //        if (jumpcount == 1)
        //        {
        //            isjump = false;
        //            anim.SetTrigger("Jump");
        //            Invoke(("PlayerJump"), 0.25f);
        //            jumpcount = 0;
        //        }


        //    }
        //}

        if (jumpCount1.isjump1==true)
        {

            jumpCount1.jumpcount1 = 1;
            if (Input.GetKeyDown(KeyCode.Space)) //점프
            {
                if (jumpCount1.jumpcount1 == 1)
                {
                    jumpCount1.isjump1 = false;
                    anim.SetTrigger("Jump");
                    Invoke(("PlayerJump"), 0.1f);
                    jumpCount1.jumpcount1 = 0;
       

                }
            }
        }


        if (GameObject.Find("GameManagerTest").GetComponent<GameManagerTest>().aabbccbal == 1 || GameObject.Find("GameManagerTest").GetComponent<GameManagerTest>().aabbccbal == 2)
        {
            if (GameObject.Find("HunchA").GetComponent<playermove>().rb.gravityScale == 5)
            {
                rb.gravityScale = 1;
            }
            if (GameObject.Find("HunchA").GetComponent<playermove>().rb.gravityScale == 1)
            {
                rb.gravityScale = 5;
            }       
        }
       

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
            transform.localScale = new Vector2(vecMoveB, vecMoveB);
            if (GameObject.Find("landingB").GetComponentInChildren<LandingB>().lanB == 0.3f)
            {
                anim.SetFloat("lan", Mathf.Abs(horizontalMove));
            }
            else if (GameObject.Find("landingB").GetComponentInChildren<LandingB>().lanB == 0)
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
            transform.localScale = new Vector2(-vecMoveB, vecMoveB);
            if (GameObject.Find("landingB").GetComponentInChildren<LandingB>().lanB == 0.3f)
            {
                anim.SetFloat("lan", Mathf.Abs(horizontalMove));
            }
            else if (GameObject.Find("landingB").GetComponentInChildren<LandingB>().lanB == 0)
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
                if(ispull ==false)
              anim.SetTrigger("pull"); 
                ispull = true;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            walk2 = 1;
            speed = (float)(v - 0.05);
            Debug.Log(walk);
        }
        if (collision.gameObject.tag == "Die")
        {
            anim.SetTrigger("Die");
        }
        if (collision.gameObject.tag == "lever")
        {
            ispull = false;
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



