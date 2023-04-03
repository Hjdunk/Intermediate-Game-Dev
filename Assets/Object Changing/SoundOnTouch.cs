using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnTouch : MonoBehaviour, iTouchable
{
    
    AudioSource aS;
    void Start()
    {
        aS = GetComponent<AudioSource>();
    }

    public void OnTouch()
    {
        aS.Play();
    }
    public void OnStopTouch()
    {
        aS.Stop();
    }
   
}
