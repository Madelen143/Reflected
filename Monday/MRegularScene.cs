using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MRegularScene : MonoBehaviour
{   
    public GameObject dialogueDisplay;
    public GameObject nextButton;
    public GameObject background;

    // Start is called before the first frame update
    void Start() {
        nextButton.SetActive(true);
        background.SetActive(true);
    }

    public void nextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
