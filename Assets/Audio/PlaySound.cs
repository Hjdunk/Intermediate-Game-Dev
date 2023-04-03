using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    
    public AudioSource meow;
    [SerializeField]
    List<AudioClip> clips;
   void OnEnable()
    {
        Collectable.collect += Play;
    }
    void OnDisable()
    {
        Collectable.collect -= Play;
        
    }
    
    void Play()
    {
        meow.PlayOneShot(clips[Random.Range(0,clips.Count)]);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        meow = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
