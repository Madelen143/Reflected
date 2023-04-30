using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WAlarm : MonoBehaviour
{
    public static WAlarm instance;
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
        if (SceneManager.GetActiveScene().name == "3Wednesday[Gym]") {
            Destroy(gameObject);
        }
    }
}
