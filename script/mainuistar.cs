using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainuistar : MonoBehaviour
{
    GameObject counting;
    public GameObject[] starss;
    // Start is called before the first frame update
    void Start()
    {
        counting = GameObject.Find("StarCounting");
    }

    // Update is called once per frame
    void Update()
    {
        countingstar();
    }

    void countingstar()
    {
     /*   if (Mainstar.Instance.clear ==4)
        {
            if (Mainstar.Instance.a == 1)
            {
                starss[0].SetActive(true);
            }
            if (Mainstar.Instance.b == 2)
            {
                starss[1].SetActive(true);
            }
            if (Mainstar.Instance.c == 3)
            {
                starss[2].SetActive(true);
            }*/
        }
    }


