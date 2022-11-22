using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using UnityEngine.U2D;


public class bosangbox1: MonoBehaviour
{
    public GameObject bornbox1, spritebox1;
    public GameObject puzle12;
    public  Animator animator1, animator2;
    int bosangA;
    // Start is called before the first frame update
    void Start()
    {
        
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
            bornbox1.SetActive(false);
            spritebox1.SetActive(true);
            if (spritebox1.activeSelf == true)
            {
                animator2.SetBool("bosang2", true);
                puzle12.SetActive(true);
            }
        }
    }
     void bosang()
    {
        if (Mainstar.Instance.clear[4] == 8)
        {
            bosangA = 1;
            animator1.SetBool("bosang", true);
        }
        else bosangA = 0;
    }
}
