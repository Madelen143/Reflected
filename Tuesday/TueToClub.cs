using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TueToClub : MonoBehaviour
{
    public GameObject dialogueDisplay;
    public GameObject nextButton;
    public GameObject background; 

    // Start is called before the first frame update
    void Start() {
        nextButton.SetActive(true);
        background.SetActive(true);
    }

    public void SceneChange(){
        SceneManager.LoadScene("3.0Tuesday[Club]");
    }
}
