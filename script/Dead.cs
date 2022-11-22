using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Dead : MonoBehaviour
{

    public GameObject dead;
    public GameObject DeadMenuCanvas;
    public static bool WDead;

    private void Start()
    {
        WDead = false;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerA" || collision.gameObject.tag == "PlayerB") {
            Debug.Log("die2");
            GameObject.Find("HunchA").GetComponent<playermove>().enabled = false;
            GameObject.Find("HunchB").GetComponent<playermoveB>().enabled = false;
            DeadMenuCanvas.SetActive(true);

        }
    }

    public void Update()
    {
        if(WDead == true)
        {
            dead.SetActive(false);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }



    public void End()
    {
        Application.Quit();
    }

}
