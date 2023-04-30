using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WIceCream : MonoBehaviour {
    public GameObject dialogueDisplay1;
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;
    public GameObject text;


    // Start is called before the first frame update
    void Start() {
        buttonOption1.SetActive(false);
        buttonOption2.SetActive(false);
        dialogueDisplay1.SetActive(true);
        nextButton.SetActive(true);
        background.SetActive(true);
    }

    public void nextClick() {
        text = GameObject.FindWithTag("Text");
        text.SetActive(false);
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
        nextButton.SetActive(false);
    }

    public void iceCream() {
        MGettingReady.points -= 1; 
        nextScene();
    }

    public void noIceCream() {
        MGettingReady.points += 1; 
        nextScene();
    }

    public void nextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}