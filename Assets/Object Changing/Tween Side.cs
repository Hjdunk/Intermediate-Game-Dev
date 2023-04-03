using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenSide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         LeanTween.moveX(gameObject, 10f, 1).setLoopPingPong();
    }
}
