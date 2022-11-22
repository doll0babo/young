using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour
{
    public GameObject box1, box2;
    
    private Rigidbody2D rb;
    float posx, pos,posz,rx,ry;
    Vector3 possz;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        posx = box1.transform.position.x;
        pos = box2.transform.position.y;
        posz = box1.transform.rotation.z;
        rx = box2.transform.rotation.x;
        ry = box2.transform.rotation.y;
        transform.position = new Vector2(posx, pos);
        transform.rotation = Quaternion.Euler(rx, ry, posz);
        rb.AddForce(Vector2.up * Time.deltaTime, ForceMode2D.Impulse);
        rb.AddForce(Vector3.forward* Time.deltaTime, (ForceMode2D)ForceMode.Impulse);
        //   rb.transform.position = new Vector2(posx, posy);
    }
}
