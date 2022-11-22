using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosangmenu : MonoBehaviour
{
    bool Hints;
    public GameObject HintsMenu;
    // Start is called before the first frame update
    void BBosangmenu()
    {
        HintsMenu.SetActive(true);
       Hints = true;
    }
    public void Hint()
   { 
            HintsMenu.SetActive(false);
            Hints = false;
    }
}
