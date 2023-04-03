using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChangeScene : MonoBehaviour, iSelectable
{
    public void Select()
    {
        SceneManager.LoadScene(1);
    }
    
}
