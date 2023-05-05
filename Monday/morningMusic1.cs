using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//! citing code from https://pastebin.com/MkQM5LS7 & https://pastebin.com/GY8g9GsG
public class morningMusic1 : MonoBehaviour
{
    public static morningMusic1 instance;

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
        if (SceneManager.GetActiveScene().name == "1Tuesday[WakingUp]") {
            Destroy(gameObject);
        }
    }
}

