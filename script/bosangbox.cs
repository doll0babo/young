using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using UnityEngine.U2D;


public class bosangbox : MonoBehaviour
{
    public GameObject bornbox, spritebox;
    public GameObject puzle11;
    public  Animator animator1, animator2;
    int bosangA;
    // Start is called before the first frame update
    void Start()
    {
        bosangA = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bosang();        
    }

   void OnMouseUp()
    {
        Debug.Log("click");

        if (bosangA == 1)
        {
            bornbox.SetActive(false);
            spritebox.SetActive(true);
            if (spritebox.activeSelf == true)
            {
                animator2.SetBool("bosang2", true);
                puzle11.SetActive(true);
            }
        }
    }
     void bosang()
    {
        if (Mainstar.Instance.clear[2] == 6)
        {
            bosangA = 1;
            animator1.SetBool("bosang", true);
        }
        else bosangA = 0; 
    }
}
