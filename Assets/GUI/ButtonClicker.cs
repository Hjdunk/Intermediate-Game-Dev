using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonClicker : MonoBehaviour
{
    public TMPro.TextMeshProUGUI buttonclicker;
    void Start()
    {
        buttonclicker = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        buttonclicker.text = "click: " + SaveManager.clicks.ToString();
    }
    

    public static void Link()
    {
        SaveManager.IncrementClicks();
    }
}
