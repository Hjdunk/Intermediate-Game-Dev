using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;


public class InputManager : MonoBehaviour
{
    PlayerInputActions actions;
    public static InputManager instance;
    public static Action OnJump;
    public static Action OnJumpDown;
    public static Action OnJumpUp;
    public static Action<Vector2> movement;
    public static Action stopMovement;
    public static Action <float>cameraRotate;
    public static Action stopCameraRotate;
    public static Action UIselect;
    public static Action <int>UiContoller;
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
        actions = new PlayerInputActions();//Not preferred, fine for now?
    }
    void OnDisable()//unsubscribe
    {
        //actions.Keyboardandmouse.Disable();
        actions.Keyboardandmouse.Jump.performed -= InvokeJumpDown;
        actions.Keyboardandmouse.Jump.canceled -= InvokeJumpUp;
        actions.Keyboardandmouse.Movement.performed -= InvokeMovement;
        actions.Keyboardandmouse.Movement.canceled -= InvokeStopMovement;
        actions.Keyboardandmouse.RotateCamera.performed -= InvokeRotateCamera;
        actions.Keyboardandmouse.RotateCamera.canceled -= InvokeStopCamera;
        actions.Keyboardandmouse.UIselect.performed -= InvokeSelect;
        actions.Keyboardandmouse.UIcontroller.performed -= InvokeUicontroller;
        actions.Keyboardandmouse.Disable();
       
    }    
    void OnEnable()//subscribe
    {
        actions.Keyboardandmouse.Jump.performed += InvokeJumpDown;//invoke jump pressed everytime you press space bar
        actions.Keyboardandmouse.Jump.canceled += InvokeJumpUp; //invoke jump 
        actions.Keyboardandmouse.Movement.performed += InvokeMovement;
        actions.Keyboardandmouse.Movement.canceled += InvokeStopMovement;
        actions.Keyboardandmouse.RotateCamera.performed += InvokeRotateCamera;
        actions.Keyboardandmouse.RotateCamera.canceled += InvokeStopCamera;
        actions.Keyboardandmouse.UIselect.performed += InvokeSelect;
        actions.Keyboardandmouse.UIcontroller.performed += InvokeUicontroller;
        actions.Enable();
        //actions.Keyboardandmouse.Enable();
    }

    void InvokeSelect(InputAction.CallbackContext ctx)
    {
        UIselect?.Invoke();
    }

    void InvokeUicontroller(InputAction.CallbackContext ctx)
    {
        UiContoller?.Invoke((int)ctx.ReadValue<float>());
    }

    void InvokeMovement(InputAction.CallbackContext ctx)
    {
        movement?.Invoke(ctx.ReadValue<Vector2>());
    }
    void InvokeStopMovement(InputAction.CallbackContext ctx)
    {
        stopMovement?.Invoke();
    }
    void InvokeRotateCamera(InputAction.CallbackContext ctx)
    {
        cameraRotate?.Invoke(ctx.ReadValue<float>());
    }
    void InvokeStopCamera(InputAction.CallbackContext ctx)
    {
        stopCameraRotate?.Invoke();
    }
    void InvokeJumpUp(InputAction.CallbackContext ctx)
    {
        OnJumpUp?.Invoke();
    }
    void InvokeJumpDown(InputAction.CallbackContext ctx)
    {
        OnJumpDown?.Invoke();//question mark, if nobody is subscribed to an event, don't subscribe it
    }   
}
