using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PipeGame : MonoBehaviour, IPointerClickHandler
{
    float[] rotations = { 0, 90, 180, 270 };

    public float[] crotate;
    [SerializeField]
    bool isPlace = false;

    int possible = 1;

    GameObject PipeMgr;

    private void Awake() 
    {
        PipeMgr = GameObject.Find("pipe"); 
    }

    void Start()
    {
       
        possible = crotate.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        if (possible > 1)
        {
            if (transform.eulerAngles.z == crotate[0] || transform.eulerAngles.z == crotate[1] )
            {
                isPlace = true;
                PipeMgr.GetComponent<PipeGameMgr>().correctMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == crotate[0])
            {
                isPlace = true;
                PipeMgr.GetComponent<PipeGameMgr>().correctMove();
            }
        }
    }

    public void Update()
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        transform.Rotate(new Vector3(0, 0, 90));

        if (possible > 1)
        {
            if (transform.eulerAngles.z == crotate[0] || transform.eulerAngles.z == crotate[1] && isPlace == false)
            {
                isPlace = true;
                PipeMgr.GetComponent<PipeGameMgr>().correctMove();
            }
            else if (isPlace == true)
            {
                isPlace = false;
                PipeMgr.GetComponent<PipeGameMgr>().wrongMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == crotate[0] && isPlace == false)
            {
                isPlace = true;
                PipeMgr.GetComponent<PipeGameMgr>().correctMove();
            }
            else if (isPlace == true)
            {
                isPlace = false;
                PipeMgr.GetComponent<PipeGameMgr>().wrongMove();
            }
        }
    }
}
