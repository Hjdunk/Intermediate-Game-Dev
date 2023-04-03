using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    [SerializeField]
    Color newColor;
    Renderer ren;
    void Start()
    {
        ren = GetComponent<Renderer>();
        coroutine = ChangeColor();
        StartCoroutine(coroutine);
       // GetComponent<Renderer>().material.color = newColor;
    }
    IEnumerator coroutine;
    IEnumerator ChangeColor()
    {
        while(true)
        {
            ren.material.color = Random.ColorHSV();
            yield return new WaitForSeconds(1f);
        }   
    }
    void OnDisable()
    {
        StopCoroutine(coroutine);
    }
    void Update()
    {
    }
    void Awake()
    {
        CChanger.i = 10;//References the CChanger code set. It doesn't do anything because it just has an i

    }
}
