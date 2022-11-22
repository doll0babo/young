using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBalpanTrueTwo : MonoBehaviour
{
    public GameObject ggbalpan, ggbalpan2;
   public bool sidebal;
    // Start is called before the first frame update
    void Start()
    {
        sidebal = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(sidebal == true)
        {
            ggbalpan.GetComponent<sideBalpanTrue>().sidebals = true;
            ggbalpan2.GetComponent<sideBalpanTrue>().sidebals = true;

        }
    }
}
