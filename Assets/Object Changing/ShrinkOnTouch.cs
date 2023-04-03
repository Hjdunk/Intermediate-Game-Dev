using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkOnTouch : MonoBehaviour, iTouchable
{
    bool isTouching = false;

    void Update()
    {
        if(isTouching)
        {
            transform.localScale -= Vector3.one * Time.deltaTime/1;
        }
    }
    public void OnTouch()
    {
        isTouching = true;
    }
    public void OnStopTouch()
    {
        isTouching = false;
        transform.localScale = Vector3.one;
    }


}
