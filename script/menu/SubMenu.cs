using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubMenu : MonoBehaviour {
    public static bool Paused = false;
    public static bool Hints = false;
    public GameObject pauseMenuCanvas, HintsMenu;
    public GameObject ExitMenu;
  
    
    
    
    public void Update() { 
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (Paused) { 
                 Pause();
                 Hint();
            //    Hintsss();
            }
            else { 
                Resume();

            } 
        }
    }
    public void Pause() { 
        pauseMenuCanvas.SetActive(false); 
        Time.timeScale = 1f; Paused = false; 
    }

    
    public void Resume() { 
        pauseMenuCanvas.SetActive(true); 
        Time.timeScale = 0f; 
        Paused = true; }

    public void End() {     
        Application.Quit();
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void menu()
    {
        SceneManager.LoadScene("stage");
    }
    public void Close()
    {
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;  Paused = false;
    }
public void Hint()
    {

        HintsMenu.SetActive(false);
        Time.timeScale = 1f; Hints = false;
    }

    public void Hintsss()
    {
        //  Destroy(GameObject.Find("bangbup"));
        startcradit.start = 1;
        GameObject.Find("bangbup").SetActive(false);
        Time.timeScale = 1f; 
    }

}
