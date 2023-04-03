using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;
using TMPro;

public class UiManger : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI[] menuOptions;
    int selection = 0;

    void Start()
    {
//        menuOptions[selection].color = Color.red;
    }

    void OnEnable()
    {
        InputManager.UIselect += SelectOption;
        InputManager.UiContoller += ChangeSelection;
    }

    void OnDisable()
    {
        InputManager.UIselect -= SelectOption;
        InputManager.UiContoller -= ChangeSelection;
    }

    void ChangeSelection(int dir)
    {
        menuOptions[selection].color = Color.white;

        selection += dir;

        if(selection > menuOptions.Length - 1)
        {
            selection = 0;
        }
        else if (selection <0)
        {
            selection = menuOptions.Length - 1;
        }

        menuOptions[selection].color = Color.red;
    }
    void SelectOption()
    {
        menuOptions[selection].transform.parent.GetComponent<iSelectable>().Select();//grabs anything that references the interface
    }

}
