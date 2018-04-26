using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour{
    public AudioSource Audio;
    int SoundLoudness = 1;

     void Start()
     {
         Audio = GetComponent<AudioSource> ();
         while (CompareTag("Player") ==  true)
         {
             Audio.Play ();
             break;
         }
     }
}

//while