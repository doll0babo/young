using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class puzleboa : MonoBehaviour, IDropHandler
{
    private RectTransform rect;
    public GameObject num;
    public bool a;
    public int puzlecount;
    // Start is called before the first frame update

    public void Start()
    {
        a = false;
        puzlecount = 0;
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("asdasd");
        if(eventData.pointerDrag != null)
        {
            if (a == true) {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == num)
        {
            Debug.Log("true");
            a = true;
            if (a == true)
            {
                puzlecount += 1;
                if (puzlecount > 2)
                {
                    puzlecount = 1;
                }
            }
           
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject == num)
        {
            Debug.Log("false");
            a = false;
            puzlecount = 0;
        }
    }
}
