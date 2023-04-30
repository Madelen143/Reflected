using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThAlarm : MonoBehaviour
{
    public static ThAlarm instance;
    // Start is called before the first frame update
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
        if (SceneManager.GetActiveScene().name == "3.0Thursday[BreakfastSelection]") {
            Destroy(gameObject);
        }
    }
}
