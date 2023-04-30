using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TMornMusic : MonoBehaviour
{
    public static TMornMusic instance;
 
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
        if (SceneManager.GetActiveScene().name == "4Tuesday[NightAd]") {
            Destroy(gameObject);
        }
    }
}
