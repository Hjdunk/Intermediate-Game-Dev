using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChangeOnCollision : MonoBehaviour
{

    Renderer ren;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {

        //if(collision.gameObject.name.Equals("Sphere")) //Used to check if a named object will change the color of another object
        //{
            ren.material.color = Random.ColorHSV();
        //}
    }

    
}
