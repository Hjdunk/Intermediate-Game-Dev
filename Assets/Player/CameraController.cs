using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;
    float dir;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(dir != 0)
        {
            transform.Rotate(0f, speed * dir * Time.deltaTime, 0f, Space.World);
        }
    }
    void OnEnable()
    {
        InputManager.cameraRotate += Rotate;
        InputManager.stopCameraRotate += StopRotate;
    }

    void OnDisable()
    {
        InputManager.cameraRotate -= Rotate;
        InputManager.stopCameraRotate -= StopRotate;
    }
    void Rotate(float dir)
    {
        this.dir = dir;
    }
    void StopRotate()
    {
        dir = 0f;
    }
}
