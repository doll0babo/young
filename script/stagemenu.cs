using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class stagemenu : MonoBehaviour
{
   public GameObject[] stagepage;
    public BTNType currentType;
    int i;
 
    // Start is called before the first frame update
    void Start()
    {


     }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnBtnClick()
    {
      
          /*  stagepage[stagepage.Length - 1].SetActive(true);
            stagepage[i].SetActive(false);*/
        
        switch (currentType)
        {
            case BTNType.Front:             
                    if (stagepage[0].activeSelf == true)
                    {
                        stagepage[0].SetActive(false);
                        stagepage[1].SetActive(true);              
                    }
                break;
            case BTNType.Back:
                if (stagepage[1].activeSelf == true)
                {
                    stagepage[1].SetActive(false);
                    stagepage[0].SetActive(true);               
                }
                break;
            case BTNType.Front2:
                if (stagepage[1].activeSelf == true)
                {
                    stagepage[1].SetActive(false);
                    stagepage[2].SetActive(true);
                }
                break;
            case BTNType.Back2:
                if (stagepage[2].activeSelf == true)
                {
                    stagepage[2].SetActive(false);
                    stagepage[1].SetActive(true);
                }
                break;

            case BTNType.Option:
                stagepage[0].SetActive(true);
                Debug.Log("옵션");
                break;
            case BTNType.Quit:
                Debug.Log("종료");
                Application.Quit();
                break;
            case BTNType.close:
                stagepage[0].SetActive(false);
                break;
            case BTNType.mainmenu:
                SceneManager.LoadScene("main");
                break;
            case BTNType.tutorial:
                SceneManager.LoadScene("Tutorial");
                break;
            case BTNType.play1:
                SceneManager.LoadScene("play0");
                break;
            case BTNType.play2:
                SceneManager.LoadScene("play1");
                break;
            case BTNType.play3:
                SceneManager.LoadScene("play2");
                break;
            case BTNType.play4:
                SceneManager.LoadScene("play3");
                break;

            case BTNType.play5:
                SceneManager.LoadScene("play4");
                break;
        }

    }
}
