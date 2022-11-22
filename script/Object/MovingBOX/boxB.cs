using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxB : MonoBehaviour
{
    public GameObject box1,box2;
    private Rigidbody2D rb;
    public Component ol;
    float posx, pos;

    

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerB")
        {
            Debug.Log("밀어봐라~");

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Push")
        {
            Debug.Log("밀어라 아웃라인아~");
            ol.GetComponent<SpriteOutline>().outlineSize = 15;
            if (Input.GetKey(KeyCode.Z))
            {
                ol.GetComponent<SpriteOutline>().outlineSize = 0;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Push")
        {
            ol.GetComponent<SpriteOutline>().outlineSize = 0;
        }
    }
    


    // Update is called once per frame

    private void FixedUpdate()
    {
        posx = box1.transform.position.x;
        pos = box2.transform.position.y;
        transform.position = new Vector2(posx, pos);      

    }
}
