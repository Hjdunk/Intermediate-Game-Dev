using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuQuit : MonoBehaviour, iSelectable
{
    public void Select()
    {
        Application.Quit(1);
        //Debug.Log("Quit");
    }

    
}
