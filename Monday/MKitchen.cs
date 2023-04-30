using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MKitchen : MonoBehaviour {
    public GameObject dialogueDisplay1;
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;
    public int counter;
    public GameObject text1;
    public GameObject text2;


    // Start is called before the first frame update
    void Start() {
        counter = 0;
        buttonOption1.SetActive(false);
        buttonOption2.SetActive(false);
        dialogueDisplay1.SetActive(true);
        nextButton.SetActive(true);
        background.SetActive(true);
        text1 = GameObject.FindWithTag("Text1");
        text2 = GameObject.FindWithTag("Text2");
        text1.SetActive(true);
        text2.SetActive(false);
    }
    public void nextClick() {
        if (counter < 1) {
            nextDialogue();
        }
        else if (counter < 2) {
            displayOptions();
        }
        counter = counter + 1;
    }
    public void nextDialogue() {
        text1.SetActive(false);
        text2.SetActive(true);
    }
    public void displayOptions() {
        text2.SetActive(false);
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
        nextButton.SetActive(false);
    }
    public void eatLeftoversOption() {
        MGettingReady.points += 1; 
        SceneChange("5.1Monday[Leftovers]");
    }

    public void eatOutOption() {
        MGettingReady.points -= 1; 
        SceneChange("5.2Monday[Takeout]");
    }

    //Funcs for scene change
    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}