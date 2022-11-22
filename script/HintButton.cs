using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton : MonoBehaviour
{
    
     bool Hints ;
    public GameObject HintsMenu;
    // Start is called before the first frame update
    private void Start()
    {
        Hints = false;
    }
    public void Hint()
    {
        if (Hints == false)
        {
            HintsMenu.SetActive(true);
            Time.timeScale = 1f; Hints = true;
        }
      else  if (Hints == true)
        {
            HintsMenu.SetActive(false);
            Time.timeScale = 1f; Hints = false;
        }
    }

}
