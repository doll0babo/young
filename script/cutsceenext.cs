using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceenext : MonoBehaviour
{
    public GameObject cutnow, cutnext, endingas;
    // Start is called before the first frame update
    public void nextcut()
    {
        cutnow.SetActive(false);
        cutnext.SetActive(true);

        if(cutnow == cutnext)
        {
            endingas.SetActive(false);
           
        }
    }
}
