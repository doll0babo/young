using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
  public static  Key  state1,state2;
    public GameObject clear1, clear2;
    public GameObject ClearMenuCanvas;



    public void Start()
    {
      
    }
    private void OnTriggerStay2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerA")|| collision.gameObject.CompareTag("PlayerB"))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (state1 == true || state2 == true) {
                    ClearMenuCanvas.SetActive(true);
                    Time.timeScale = 0f;
                }
            }
        }
    }
}