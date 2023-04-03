using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScaleOnStay : MonoBehaviour
{
    void FixedUpdate()
    {

    }

    void OnTriggerStay(Collider other) //24 times per second
    {
        if(other.gameObject.name.Equals("Sphere"))
        {
            other.transform.localScale -= Vector3.one * .01f;
        }
    }


}
