using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidekey : MonoBehaviour
{
    public GameObject sideObj, KeyObj;
    Vector3 sidevec;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 sidevec = sideObj.gameObject.transform.position;
        float v = sidevec.y + 10f;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
