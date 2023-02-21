using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioClip soundEgg, soundEnemy, soundWire,soundBoom; //<---drag  mp3#2 into the inspector here
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Play(int i)
    {
        if (i == 1)
        {
            audio.clip =  soundEgg;
            audio.Play();
        }
        if ( i == 2)
        {
            audio.clip = soundEnemy;
            audio.Play();
        }
        if (i == 3)
        {
            Debug.Log("aaa");
            audio.clip = soundWire;
            audio.Play();
        }
        if (i == 4)
        {
            Debug.Log("aaa");
            audio.clip = soundBoom;
            audio.Play();
        }
    }

    
}
