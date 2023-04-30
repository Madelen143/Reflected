using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

