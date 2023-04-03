using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween : MonoBehaviour
{


    void Start()
    {
        LeanTween.moveY(gameObject, 10f, 1).setLoopPingPong();//moves object up 10 units for 5 seconds then back down
    }
}
