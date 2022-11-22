using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class endingscene : MonoBehaviour
{
    public Image image;
    float time = 0;
    float f_time = 3f;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(fadein());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  IEnumerator  fadein()
    {    
        Color alpha = image.color;

        while (alpha.a >0f) 
        {
            time += Time.deltaTime / f_time;
            alpha.a =Mathf.Lerp(1, 0, time);
            image.color = alpha;
            yield return null;
            if(alpha.a == 0)
            {
                image.enabled = false;
            }
        }
    }
}
