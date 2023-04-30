using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TuePhoneSelection : MonoBehaviour
{

    public GameObject dialogueDisplay;
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;

    // Start is called before the first frame update
    void Start() {
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
        dialogueDisplay.SetActive(true);
        nextButton.SetActive(false);
        background.SetActive(true);
    }


    public void snooze(){
        // TODO: point system
        clickedOption();
        SceneChange("2.1Tuesday[SleepMore]");
    }

    public void wakeUp() {
        // TODO: point system 
        clickedOption();
        SceneChange("2.2.0Tuesday[WakeUp]");
    }

    public void clickedOption() {
        buttonOption1.SetActive(false);
        buttonOption2.SetActive(false);
        // nextButton.SetActive(true);
    }

     public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }

 



}
