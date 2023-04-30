using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SAlarm : MonoBehaviour
{
   public static SAlarm instance;

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
        if (SceneManager.GetActiveScene().name == "3Saturday[Coupon]") {
            Destroy(gameObject);
        }
    }
}
