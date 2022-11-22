using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balpanTrue : MonoBehaviour
{
    

    public GameObject[] trueA, trueB;
    public bool valpanture, resetto;


    // Start is called before the first frame update
    void Start()
    {
        valpanture = false;

    }

    // Update is called once per frame
    void Update()
    {
        trcham();
    }

    void trcham()
    {
        for (int i = 0; i < trueA.Length; i++)
        {        
                    if (trueA[i].gameObject.GetComponent<Testpan1>().bal == true && trueB[i].gameObject.GetComponent<Testpan1>().bal == true)
                    {                          
                            valpanture = true;
                            Invoke("waaitt", 5.0f);
                        
                    }
               
        }
    }
        void waaitt()
    {
        valpanture = false;
    }

}
