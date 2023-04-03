using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sSaveManager : MonoBehaviour
{
    public static sSaveManager instance;
    public static string _cclickCount = "cclickCount";// underscore is a private variable
    public static int cclicks;
    public static string coins = "coins";
    public static int coinCount;
    void Awake()
    {
        //Singleton Pattern
        if(instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        //Player Prefs
        cclicks = PlayerPrefs.GetInt(_cclickCount, 0);//asks for the key/string grabbing an integer with a string key
    } 
    public static void IIncrementClicks()
    {
        cclicks++;
    }
    void OnApplicationQuit()
    {
        Save();

    }
    void Save()
    {
        PlayerPrefs.SetInt(_cclickCount, cclicks);
        //PlayerPrefs.SetInt(coinCount, coins);
        PlayerPrefs.Save();
        Debug.Log(cclicks);
        
    }
}
