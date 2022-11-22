using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class onending : MonoBehaviour
{
    public GameObject endingcredit, endimage, imagejin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        endingcre();
    }
 
    void endingcre()
    {
        if(endingcredit.GetComponent<gate>().stageclear == true)
        {
            imagejin.GetComponent<endingfadein>().enabled = true;
            endimage.SetActive(true);         
         //   image.enabled = true;
        }
    }

    public void endingskip()
    {
        endimage.SetActive(false);
    }

}
