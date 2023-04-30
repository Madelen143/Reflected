using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlarmMusic : MonoBehaviour
{
    public static AlarmMusic instance;
 
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
        if (SceneManager.GetActiveScene().name == "3Monday[InBed]") {
            Destroy(gameObject);
        }
    }
}