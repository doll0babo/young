using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpCount : MonoBehaviour
{
    public static jumpCount InstanceJump;
    public static int jumpcount;
    public static bool isjump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "street" || collision.gameObject.tag == "box" || collision.gameObject.tag == "seecol" || collision.gameObject.tag == "bowl" || collision.gameObject.tag == "Untagged")
        {
            isjump = true;
            jumpcount = 1;
        }
    }
    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "street" || collision.gameObject.tag == "box" || collision.gameObject.tag == "seecol" || collision.gameObject.tag == "bowl" || collision.gameObject.tag == "Untagged")
    //    {
    //        isjump = true;
    //        jumpcount = 1;
    //    }
    //}
}
