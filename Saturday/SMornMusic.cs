using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SMornMusic : MonoBehaviour
{
    public static SMornMusic instance;

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
        if (SceneManager.GetActiveScene().name == "1Sunday[Morning]") {
            Destroy(gameObject);
        }
    }
}
