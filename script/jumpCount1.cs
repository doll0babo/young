using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpCount1 : MonoBehaviour
{
    public static jumpCount1 InstanceJump;
    public static int jumpcount1;
    public static bool isjump1 = false;
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
           
            isjump1 = true;
            jumpcount1 = 1;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "street" || collision.gameObject.tag == "box" || collision.gameObject.tag == "seecol" || collision.gameObject.tag == "bowl" || collision.gameObject.tag == "Untagged")
        {

            isjump1 = false;
            jumpcount1 = 0;
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
