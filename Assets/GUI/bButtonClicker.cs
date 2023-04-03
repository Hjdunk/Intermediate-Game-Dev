using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class bButtonClicker : MonoBehaviour
{
    [SerializeField] 
    TextMeshProUGUI textBox;
    int _clicks;
    void Start()
    {
        _clicks = sSaveManager.cclicks;
        textBox.text = _clicks.ToString();

    }
    public void OnClick()
    {
        sSaveManager.IIncrementClicks();
        textBox.text = (_clicks+=1).ToString();
    }
}
