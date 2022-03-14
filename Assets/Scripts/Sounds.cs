using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource carCrash;

    public void playAudio()
    {
        carCrash.Play();
    }
}
