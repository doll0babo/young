using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEADSTOP : MonoBehaviour
{
    public GameObject PlayerA, PlayerB;
    public GameObject Camera1, Camera2;
    // Start is called before the first frame update
    public void timeline() {
        PlayerA.GetComponent<playermove>().enabled = false;
        PlayerB.GetComponent<playermoveB>().enabled = false;
        Time.timeScale = 0f;
        Camera1.SetActive(false);
        Camera2.SetActive(false);

    }
}
