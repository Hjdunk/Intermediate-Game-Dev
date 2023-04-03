using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iTouchable//Interface cannot inherit MonoBehaviour methods
{
    public void OnTouch();
    
    public void OnStopTouch();

}
