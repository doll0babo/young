using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.PlayerSettings;

public class boxAB : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject box;
    public Component ol;


    private void Update()
    {

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (playermove.vecMove > 0.7f)
        {
            if (collision.gameObject.tag == "PlayerA")
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

        if (playermove.vecMove > 0.7f)
        {
            if (collision.gameObject.tag == "PlayerB")
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
}
