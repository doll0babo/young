using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gidoung : MonoBehaviour
{

    public Transform balPos;
    public float speed;
    
    // Start is called before the first frame update
   
    public void Update()
    {
        if (GameObject.Find("downbalpan2").GetComponentInChildren<DownBalpan2>().bal == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, balPos.position, Time.deltaTime*speed);
        }
    }
}
