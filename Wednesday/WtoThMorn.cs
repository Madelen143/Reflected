using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WtoThMorn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialogueDisplay;
    public GameObject nextButton;
    public GameObject background; 

    // Start is called before the first frame update
    void Start() {
        nextButton.SetActive(true);
        background.SetActive(true);
        dialogueDisplay.SetActive(true);
    }

    public void SceneChange(){
        SceneManager.LoadScene("1Thursday[Wakeup]");
    }
}
