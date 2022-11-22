using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameStart : MonoBehaviour
{
    public GameObject mini, A;
    public Animator Scrollani;
    // Start is called before the first frame update


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerA" || collision.gameObject.tag == "PlayerB")
        {
            Scrollani.SetBool("scroll", true);
            //mini.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerA" || collision.gameObject.tag == "PlayerB")
        {
            Scrollani.SetBool("scroll", false);
            mini.SetActive(false);
            A.SetActive(false);
        }
    }

    public void scroll()
    {
        mini.SetActive(true);
    }

    void gamestart()
    {
        A.gameObject.SetActive(true);
    }

}

