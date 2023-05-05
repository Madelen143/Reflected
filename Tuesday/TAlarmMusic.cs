using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//! citing code from https://pastebin.com/MkQM5LS7 & https://pastebin.com/GY8g9GsG
public class TAlarmMusic : MonoBehaviour
{
    public static TAlarmMusic instance;
 
    void Awake() {
        
        if (instance != null) {
            Destroy(gameObject);
        }
            
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Update() {
        if (SceneManager.GetActiveScene().name == "2.1Tuesday[SleepMore]") {
            Destroy(gameObject);
        }
        if (SceneManager.GetActiveScene().name == "2.2.0Tuesday[WakeUp]") {
            Destroy(gameObject);
        }
    }
}