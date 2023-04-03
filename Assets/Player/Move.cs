using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    
    Rigidbody rig;
    [SerializeField]
    float speed = 5f;
    bool isMoving = false;
    Vector2 dir = Vector2.zero;

    [SerializeField]
    string floorTag;
    bool isJumping = false;
    
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void OnEnable()
    {
        InputManager.movement += StartMove;
        InputManager.stopMovement += StopMove;
    }
    void OnDisable()
    {
        InputManager.movement -=  StartMove;
        InputManager.stopMovement -= StopMove;
    }

    void MoveCharacter()
    {
        Vector3 newDir = new Vector3(dir.x, 0f, dir.y);
        //float newX = dir.x;
        //float NewZ = dir.y;

        //transform.Translate(newDir*speed);
        rig.AddForce(newDir * speed * Time.deltaTime, ForceMode.Impulse);//add force is cumulative
    }

    void StartMove(Vector2 dir)
    {
        this.dir = dir;
        isMoving = true;
        
    }
    void StopMove()
    {
        dir = Vector2.zero;
       // rig.velocity = Vector3.zero;//instant stop
        isMoving = false;
    }

    void FixedUpdate() //tickrate/physics time scale
    {
        if(isMoving && !isJumping)
        {
            MoveCharacter();
        }
       /* else if(rig.velocity != Vector3.zero)
        {
            rig.velocity.x/= speed*Time.deltaTime;
        }*/
    }

public void OnCollisionEnter(Collision collision)
{
        if(collision.gameObject.CompareTag(floorTag))
    { 
        isJumping = false;
    }   

}

public void OnCollisionExit(Collision collision)
{
    if(collision.gameObject.CompareTag(floorTag))
    {
        isJumping = true;
    }
}


    // Update is called once per frame
    void Update()//frame rate
    {
        
    }
}
