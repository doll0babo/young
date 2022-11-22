using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gate : MonoBehaviour
{
    //public GameObject clear1,clear2;
    public GameObject ClearMenuCanvas;
    public AudioSource audiosource;
    public bool stageclear;

    public void Start()
    {
        stageclear = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerA"|| collision.gameObject.tag == "PlayerB")
        {
            Debug.Log("clear");
            KeyEvent();             
            }
        }
    private void KeyEvent()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("Up");
            if (GameObject.Find("KEY").GetComponent<Key>().state == true)    {
                ClearMenuCanvas.SetActive(true);
                stageclear = true;
                //Time.timeScale = 0f;
                audiosource = GetComponent<AudioSource>();
                if (!audiosource.isPlaying)
                {
                    audiosource.Play();
                }
                
                Debug.Log("sad");
                }
            }        
        }        
    }

    


