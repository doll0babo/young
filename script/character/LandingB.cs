using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingB : MonoBehaviour
{

    public float lanB;
    // Start is called before the first frame update

    public void FixedUpdate()
    {
        lanB = 0f;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("box"))
        {
            lanB = 0.3f;
            Debug.Log("ttttagggg");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        lanB = 0;
    }
}
