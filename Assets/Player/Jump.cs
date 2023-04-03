using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    [SerializeField]//you can access in inspector but not in the code
    float jumpheight = 5;
    Rigidbody rig;
    [SerializeField][Range(1,3)]
    int maxJumps;
    int jumpCount = 0;

    [SerializeField]
    string floorTag;
    bool isJumping = false;
    [SerializeField]
    float arrestorMult;
    [SerializeField]
    AudioSource Audio;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    void OnEnable()
    {
        InputManager.OnJumpDown += JumpDown;
        InputManager.OnJumpUp += JumpUp;
    }
    void OnDisable()
    {
        InputManager.OnJumpDown -= JumpDown;
        InputManager.OnJumpUp -= JumpUp;
    }
    void JumpDown()
    {        
        if(jumpCount < maxJumps)
        {
            jumpCount++;
            rig.AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
        }
        Audio.Play();
    }
    void JumpUp()
    {
       //rig.AddForce(Vector3.down * jumpheight, ForceMode.Impulse); //prevents floatiness straight drop down
       //isJumping = true;
       
    }
    void FixedUpdate()//Fixed update is the physics tick rate
    {
        if(isJumping)
        {
            //JumpUp();
           // JumpDown();
        }
    }   


public void OnCollisionEnter(Collision collision)
{
    
        if(collision.gameObject.CompareTag(floorTag))
    { 
        jumpCount = 0;
    }   
}

private void Update()
{
    if(!isJumping &&rig.velocity.y >0)
    {
        rig.AddForce((Vector3.down * arrestorMult) * Time.deltaTime, ForceMode.Impulse);
    }
}

}
