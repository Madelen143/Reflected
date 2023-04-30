using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAlarm : MonoBehaviour
{

    public static FAlarm instance;

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
        if (SceneManager.GetActiveScene().name == "3Friday[NormalMorning]") {
            Destroy(gameObject);
        }
    }
}
