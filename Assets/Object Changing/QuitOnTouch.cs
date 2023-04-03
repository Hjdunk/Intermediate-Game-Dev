using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnTouch : MonoBehaviour, iTouchable
{
    public void OnTouch()
    {
        Debug.Log("Working");
        Application.Quit(1);
    }
    public void OnStopTouch(){}//doesn't do anything
}
