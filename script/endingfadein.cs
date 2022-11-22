using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class endingfadein : MonoBehaviour
{
    public Image image1;
    float time = 0;
    float f_time = 6f;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(fadein());
    }
    IEnumerator fadein()
    {
        Color alpha = image1.color;

        while (alpha.a > 0f)
        {
            time += Time.deltaTime / f_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            image1.color = alpha;
            yield return null;
            if (alpha.a == 0)
            {
                image1.enabled = false;
            }
        }
    }

}
