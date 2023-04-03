using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectable : MonoBehaviour
{

    public static Action collect;//used to broadcast to observer
    /*<int>*/



    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            transform.position = CoinObjectPool.instance.transform.position;
            collect?.Invoke();//not listening won't do anything. yerrrr
            /*"1"you can choose how many points you get in CoinObserver*/
            gameObject.SetActive(false);
            
        }
        //invokes broadcast from collect event and allows to 
    }

}


