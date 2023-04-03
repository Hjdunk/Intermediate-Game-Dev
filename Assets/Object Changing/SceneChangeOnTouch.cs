using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnTouch : MonoBehaviour, iTouchable
{
    public void OnTouch()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnStopTouch(){}//doesn't do anything
}
