using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//! citing code from https://pastebin.com/MkQM5LS7 & https://pastebin.com/GY8g9GsG
public class SunMornMusic : MonoBehaviour
{
    public static SunMornMusic instance;
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
        if (SceneManager.GetActiveScene().name == "YearsLater") {
            Destroy(gameObject);
        }
    }
}
