using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzlending : MonoBehaviour
{
    public GameObject[] puzlendig;
   public  int[] A;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        PUZLENDING();
    }

    public void PUZLENDING()
    {
        for(int i = 0; i< puzlendig.Length; i++)
        if (puzlendig[i].GetComponent<puzleboa>().a == true)
        {
                A[i] = puzlendig[i].GetComponent<puzleboa>().puzlecount;

                //if ()
                //{
                //    SceneManager.LoadScene("ending");
                //}
            }
        if (A[0]+ A[1] + A[2] + A[3] + A[4] + A[5] + A[6] + A[7] + A[8] + A[9] + A[10] + A[11] ==12)
        {
            Invoke("Counting", 3f);
        }
    }

    public void Counting()
    {
        SceneManager.LoadScene("ending");

    }
}
