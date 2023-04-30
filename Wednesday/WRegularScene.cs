using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WRegularScene : MonoBehaviour
{
    // Start is called before the first frame update
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
