using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzleBox : MonoBehaviour
{
    public static puzleBox Instance;
    public GameObject[] redright, bar;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
     
    }
    // Update is called once per frame
    void Update()
    {
        boundBox();
    }

    public void boundBox()
    {
        if (Mainstar.Instance.clear[0] == 4)
        {
            bar[0].SetActive(true);
        }
        if (Mainstar.Instance.clear[1] == 5)
        {
            bar[1].SetActive(true);
        }
        if (Mainstar.Instance.clear[2] == 6) {
            //�ִϸ��̼� �����ϰ� Ŭ���ϸ� ���� �� �ϴ°� ������ 
            redright[0].SetActive(true);
            bar[2].SetActive(true);
        }
        if (Mainstar.Instance.clear[3] == 7)
        {
            bar[3].SetActive(true);
        }
        if (Mainstar.Instance.clear[4] == 8)
        {
            bar[4].SetActive(true);
        }
        if (Mainstar.Instance.clear[4] == 8)
        {
            //�ִϸ��̼� �����ϰ� Ŭ���ϸ� ���� �� �ϴ°� ������ 
            redright[1].SetActive(true);
            bar[5].SetActive(true);
        }
    }

}
