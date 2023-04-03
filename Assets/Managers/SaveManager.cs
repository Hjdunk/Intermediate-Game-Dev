using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
 public static SaveManager instance;
 public static int clicks;
 static string _clickCount = "clickCount";


 public static void IncrementClicks()
 {
     clicks++;
 }
 private void OnApplicationQuit()
 {
    Save();
 }
 public void Save()
 {
    PlayerPrefs.Equals(_clickCount, clicks);
    PlayerPrefs.Save();
    Debug.Log(clicks);
 }
 
 private void Awake()
 {
     if(instance != null) //singleton
     {
        Destroy(this.gameObject);
     }
     else
     {
         instance = this; 
         DontDestroyOnLoad(this.gameObject);
     }

     if(PlayerPrefs.HasKey(_clickCount))
     {
        PlayerPrefs.GetInt(_clickCount, clicks);
        PlayerPrefs.SetInt(_clickCount, clicks);
     }
     else
     {
         PlayerPrefs.SetInt(_clickCount, 0);
     }
     
     
     
     
 }

 
 
}
