using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testpan : MonoBehaviour
{
    public Transform balPos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("downbalpan1").GetComponentInChildren<DownBalpan>().pan == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, balPos.position, Time.deltaTime * speed);
        }
    }
}
