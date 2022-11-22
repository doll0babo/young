using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class sideBalpanTrue : MonoBehaviour
{
    public Transform StPos;
    public Transform EdPos;
    public Transform balPos;
    public  bool sidebals;
    public float speed;
    // Start is called before the first frame update
    public void Start()
    {
        sidebals = false;
        transform.position = StPos.position;
        balPos = EdPos;
    }

    public void Update()
    {
        if (sidebals == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, balPos.position, Time.deltaTime * speed);
            if (Vector2.Distance(transform.position, balPos.position) <= 0.05f)
            {
                if (balPos == EdPos) balPos = StPos;
                else balPos = EdPos;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("PlayerA") || collision.transform.CompareTag("PlayerB"))
        {
            collision.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("PlayerA") || collision.transform.CompareTag("PlayerB"))
        {
            collision.transform.SetParent(null);
        }
    }
}
