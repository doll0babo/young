using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeGameMgr : MonoBehaviour
{


    public GameObject PipesHolder, me, clear, scroll, distory, distory2, tile;

    public GameObject[] Pipes;
    int totalPipes = 0;
    [SerializeField]
    int corretedPipe = 0;
    private float  Limit;
    public Text PipeTime;
    public bool pipebool;

    // Start is called before the first frame update
    void Start()
    {
      
        Limit = 30;
        totalPipes = PipesHolder.transform.childCount;
        Pipes = new GameObject[totalPipes];

        for(int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    }

    private void Update()
    {
        Limit -= Time.deltaTime;
        PipeTime.text = ((int)Limit % 60).ToString();
        if(Limit <= 0)
        {
            Limit = 30;
            me.SetActive(false);
        }
    }

    // Update is called once per frame
    public void correctMove() 
    {
        corretedPipe += 1;
        Debug.Log("go move");
        if (corretedPipe == totalPipes) 
        {
            pipebool = true;
            clear.SetActive(true);
            Invoke("clearr", 1.5f);         
            Debug.Log("you win");
        }
    }

    public void wrongMove() 
    {
        pipebool = false;
        corretedPipe -= 1;

    }

    void clearr() 
    {
        me.SetActive(false);
        scroll.SetActive(false);
        distory.SetActive(false);
        distory2.SetActive(false);
        tile.SetActive(true);
    }
}
