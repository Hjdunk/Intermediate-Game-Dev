using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinObserver : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI coins;
    int coinCount;

    //[SerializeField]
    //List<AudioClip> clips;
    [SerializeField]
    AudioSource Audio;
    void IncrementCount(/*"int scoreToAdd" this is how you can also choose how many points you can get*/)
    {
        coinCount++;
    }
    public void PlayOnCollect()
    {
        Audio.Play();
        //Audio.PlayOneShot(clips[Random.Range(0,clips.Count)]);//should play random sound
    }
    void OnEnable()
    {
        Collectable.collect += IncrementCount;
        Collectable.collect += PlayOnCollect;
    }
    void OnDisable()
    {
        Collectable.collect -= IncrementCount;
        Collectable.collect -= PlayOnCollect;
    }
    void Start()
    {

    }
    void Update()
    {
        coins.text = coinCount.ToString();
    }
}
