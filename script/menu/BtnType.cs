using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public GameObject optionmenu;
    private void Start()
    {
       // defaultScale = buttonScale.localScale;
    }

    public void OnBtnClick()
    {
        switch(currentType)
        {
            case BTNType.New:
                SceneManager.LoadScene("stage");
                Debug.Log("������");
                break;
            case BTNType.Sound:
                Debug.Log("�Ҹ�");
                break;
            case BTNType.Back:
                Debug.Log("�ڷ�");
                break;
            case BTNType.Option:
                optionmenu.SetActive(true);
                Debug.Log("�ɼ�");
                break;
            case BTNType.Quit:
                Debug.Log("����");
                Application.Quit();
                break;

        }
    }
    /*public static void LoadSceneHandle(string_name, int_loadType)
    { 
    
    }*/

    public void OnPointerEnter(PointerEventData eventData)
    {
        //buttonScale.localScale = defaultScale *1.2f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
      //  buttonScale.localScale = defaultScale;
    }
}

