using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class CoinObjectPool : MonoBehaviour
{
    GameObject[] pooledObjects;
    

    [SerializeField]
    GameObject objectToPool;
    [SerializeField]
    [Range(1f,10f)]
    public int maxPooledObjects;   
    
    [SerializeField]
    Transform spawner;

    public static CoinObjectPool instance;

    
    void Awake()
    {
    
        if(instance) //singleton Code
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;  
        }
    }

    void Start()
    {     
        pooledObjects = new GameObject[maxPooledObjects];
        GameObject tempObj;
        for(int i = 0; i<maxPooledObjects;i++)//goes through every object in the array and avoids nulls
        {
            tempObj = Instantiate(objectToPool);//stores in a list
            pooledObjects[i] = tempObj;
            tempObj.transform.position = transform.position;
            tempObj.SetActive(false);
            
        }
        StartCoroutine("SpawnPoolObject");
    }
    public GameObject GetPoolObject()
    {
        foreach(GameObject obj in pooledObjects)
        {
            if (!obj.activeSelf)
            {
                return obj;
            }
        }
        Debug.LogWarning("Inactive Object not found in Pool");
        return null;
    }

    IEnumerator SpawnPoolObject()
    {
        for (; ; )
        {
            if (GetPoolObject())
            {
                GameObject temp = GetPoolObject();
                temp.transform.position = spawner.position;
                temp.SetActive(true);
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
