using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box2 : MonoBehaviour
{
    public GameObject boxB;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerA")|| collision.gameObject.CompareTag("PlayerB"))
        {
            boxB.SetActive(true);
        }
    }
}
