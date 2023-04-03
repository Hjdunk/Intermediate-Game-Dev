using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinBar : MonoBehaviour
{
    public Slider coinBar;

    float collected;

    void OnEnable()
    {
        Collectable.collect += CoinCollected;
        
    }

    
    void OnDisable()
    {
        Collectable.collect -= CoinCollected;
    }

    void CoinCollected()
    {
        collected += 1;
        coinBar.value = collected;
    }
    void Start()
    {
        collected = 0;
    }
    // Update is called once per frame
    void Update()
    {
        //if(coinBar.value == 10)
        //{
          //  coinBar.value -=*(Time.deltaTime);
        //}
    }
}
