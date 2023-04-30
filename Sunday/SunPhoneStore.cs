using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SunPhoneStore : MonoBehaviour
{
    public GameObject dialogueDisplay1;
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;
    public int counter;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    

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
        text3 = GameObject.FindWithTag("Text3");
        text1.SetActive(true);
        text2.SetActive(false);
        text3.SetActive(false);
    }

    public void nextClick() {
        if (counter < 1) {
            nextDialogue();
        }
        else if (counter < 2) {
            nextDialogue2();
        }
        else if (counter < 3) {
            displayOptions();
        }
        counter = counter + 1;
    }

    public void nextDialogue() {
        text1.SetActive(false);
        text2.SetActive(true);
        text3.SetActive(false);
    }

    public void nextDialogue2() {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(true);
    }

    public void displayOptions() {
        nextButton.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
    }
    
    
    public void upgradePhone() {
        MGettingReady.points -= 2; 
        SceneChange("2.1Sunday[NewPhone]");
    }

    public void keepPhone() {
        MGettingReady.points += 1; 
        SceneChange("2.2Sunday[OldPhone]");
    }

    //Funcs for scene change
    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}
