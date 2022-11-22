using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using static Unity.VisualScripting.Round<TInput, TOutput>;

public class camera : MonoBehaviour
{

    private bool state1, state2;
    public GameObject Camera1, Camera2;
    public GameObject PlayerA, PlayerB;
    public GameObject PlayerTagA, PlayerTagB;
    public GameObject LandA, EndingE;
    public AudioSource soundA, soundB, soundC;

    //  public AudioClip[] sound12;
    public AudioListener ListenerA, ListenerB;

    public void Start()
    {
        state1 = true;
        state2 = false;
        soundA.GetComponent<AudioSource>();
        soundB.GetComponent<AudioSource>();
        soundC.GetComponent<AudioSource>();
        ListenerA.GetComponent<AudioListener>();
        ListenerB.GetComponent<AudioListener>();
        soundB.Pause();
        soundC.Pause();
        EndingE.SetActive(false);
    }

    private void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.A))
        {

            if (state1 == false)
            {
                Camera1.SetActive(true);
                PlayerTagA.SetActive(true);
                state1 = true;
                Camera2.SetActive(false);
                PlayerTagB.SetActive(false);
                state2 = false;
                PlayerA.GetComponent<playermove>().enabled = true;
                PlayerB.GetComponent<playermoveB>().enabled = false;
                LandA.GetComponent<Landing>().enabled = true;
                ListenerA.GetComponent<AudioListener>().enabled = true;
                ListenerB.GetComponent<AudioListener>().enabled = false;
                soundA.Play();
                soundB.Pause();
                StopCoroutine("Playlist");
            }

        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            if (state2 == false)
            {
                // StartCoroutine("Playlist");
                Camera2.SetActive(true);
                PlayerTagB.SetActive(true);
                state2 = true;
                Camera1.SetActive(false);
                PlayerTagA.SetActive(false);
                state1 = false;
                PlayerA.GetComponent<playermove>().enabled = false;
                PlayerB.GetComponent<playermoveB>().enabled = true;
                LandA.GetComponent<Landing>().enabled = false;
                ListenerA.GetComponent<AudioListener>().enabled = false;
                ListenerB.GetComponent<AudioListener>().enabled = true;
                soundA.Pause();
                soundB.Play();
            }
        }

     if (!soundC.isPlaying)
        {
            if (EndingE.activeSelf == true)
            {
                soundA.Pause();
                soundB.Pause();
                soundC.Play();
            }
        }

    }
}



