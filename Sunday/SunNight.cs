using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SunNight : MonoBehaviour
{
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;
    public GameObject dialogueDisplay1;
    public GameObject text;


    //Start the scene with text and no buttons visable yet
    void Start() {  
        buttonOption1.SetActive(false);
        buttonOption2.SetActive(false);
        nextButton.SetActive(true);
        background.SetActive(true);
        dialogueDisplay1.SetActive(true);
        text = GameObject.FindWithTag("Text");
    }

    public void nextClick() {
        text.SetActive(false);
        nextButton.SetActive(false);
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
    }

    public void quickShower(){
        MGettingReady.points += 1; 
        SceneChange("3.1Sunday[QuickShower]");
    }

    public void longShower() {
        MGettingReady.points -= 1; 
        SceneChange("3.2Sunday[LongShower]");
    }

    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}
