using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    AudioSource aS;
    void Start()
    {
        aS = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision collision)
    {
        aS.Play();
        
    }

    
}
