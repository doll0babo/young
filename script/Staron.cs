using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Staron : MonoBehaviour
{
    public GameObject[] staroffon, ppuzzle, rock;

    public static Staron Instance;
    
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        tutorial();
        stage1();
        stage2();   
        stage3();
        stage4();
        stage5();
        Rock();
    }


    public void stage1()
    {
        if (Mainstar.Instance.clear[0] == 4)
        {
            if (Mainstar.Instance.abc[0] == 1)
            {
                staroffon[0].transform.GetChild(0).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[1] == 2)
            {
                staroffon[0].transform.GetChild(1).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[2] == 3)
            {
                staroffon[0].transform.GetChild(2).gameObject.SetActive(true);
            }

            if (Mainstar.Instance.puzzlee[0] == 1)
            {
                ppuzzle[0].gameObject.SetActive(true);
            }
            if (Mainstar.Instance.puzzlee[1] == 2)
            {
                ppuzzle[1].gameObject.SetActive(true);
            }

        }
    }
    public void stage2()
    {
        if (Mainstar.Instance.clear[1] == 5)
        {
            if (Mainstar.Instance.abc[3] == 6)
            {
                staroffon[1].transform.GetChild(0).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[4] == 7)
            {
                staroffon[1].transform.GetChild(1).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[5] == 8)
            {
                staroffon[1].transform.GetChild(2).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.puzzlee[2] == 3)
            {
                ppuzzle[2].gameObject.SetActive(true);
            }
            if (Mainstar.Instance.puzzlee[3] == 4)
            {
                ppuzzle[3].gameObject.SetActive(true);
            }

        }
    }
    public void stage3()
    {
        if (Mainstar.Instance.clear[2] == 6)
        {
            if (Mainstar.Instance.abc[6] == 9)
            {
                staroffon[2].transform.GetChild(0).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[7] == 10)
            {
                staroffon[2].transform.GetChild(1).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[8] == 11)
            {
                staroffon[2].transform.GetChild(2).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.puzzlee[4] == 5)
            {
                ppuzzle[4].gameObject.SetActive(true);
            }
            if (Mainstar.Instance.puzzlee[5] == 6)
            {
                ppuzzle[5].gameObject.SetActive(true);
            }

        }
    }
    public void stage4()
    {
        if (Mainstar.Instance.clear[3] == 7)
        {
            if (Mainstar.Instance.abc[9] == 12)
            {
                staroffon[3].transform.GetChild(0).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[10] == 13)
            {
                staroffon[3].transform.GetChild(1).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[11] == 14)
            {
                staroffon[3].transform.GetChild(2).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.puzzlee[6] == 7)
            {
                ppuzzle[6].gameObject.SetActive(true);
            }
            if (Mainstar.Instance.puzzlee[8] == 9)
            {
                ppuzzle[7].gameObject.SetActive(true);
            }

        }
    }


    public void stage5()
    {
        if (Mainstar.Instance.clear[4] == 8)
        {
            if (Mainstar.Instance.abc[12] == 15)
            {
                staroffon[4].transform.GetChild(0).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[13] == 16)
            {
                staroffon[4].transform.GetChild(1).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.abc[14] == 17)
            {
                staroffon[4].transform.GetChild(2).gameObject.SetActive(true);
            }
            if (Mainstar.Instance.puzzlee[8] == 9)
            {
                ppuzzle[8].gameObject.SetActive(true);
            }
            if (Mainstar.Instance.puzzlee[9] == 10)
            {
                ppuzzle[9].gameObject.SetActive(true);
            }

        }
    }

    public void tutorial()
    {
        if(Mainstar.Instance.clear[5] == 3)
        {
            staroffon[5].gameObject.SetActive(true);
        }
    }

    public void Rock()
    {
        if (Mainstar.Instance.clear[5] == 3)
        {
            rock[0].gameObject.SetActive(false);
        }
        if (Mainstar.Instance.clear[0] == 4)
        {
            rock[1].gameObject.SetActive(false);
        }
        if (Mainstar.Instance.clear[1] == 5)
        {
            rock[2].gameObject.SetActive(false);
        }
        if (Mainstar.Instance.clear[2] == 6)
        {
            rock[3].gameObject.SetActive(false);
        }
        if (Mainstar.Instance.clear[3] == 7)
        {
            rock[4].gameObject.SetActive(false);
        }

    }

}
