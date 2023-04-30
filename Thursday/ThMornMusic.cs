using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThMornMusic : MonoBehaviour
{
    public static ThMornMusic instance;
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
        if (SceneManager.GetActiveScene().name == "1Friday[Wakeup]") {
            Destroy(gameObject);
        }
    }
}
