using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<iTouchable>() != null)
        {
            collision.gameObject.GetComponent<iTouchable>().OnTouch();
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.GetComponent<iTouchable>() != null)
        {
            collision.gameObject.GetComponent<iTouchable>().OnStopTouch();
        }
    }
}
