using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownBox : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("lever").GetComponentInChildren<lever>().lver == true)
        {
            rb.gravityScale = 3;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerA") || collision.gameObject.CompareTag("PlayerB"))
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
