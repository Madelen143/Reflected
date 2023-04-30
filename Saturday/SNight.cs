using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SNight : MonoBehaviour
{
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
        text = GameObject.FindWithTag("Text");
    }

    public void nextClick() {
        text.SetActive(false);
        nextButton.SetActive(false);
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
    }
 
    public void bubbleBath() {
        MGettingReady.points -= 1; 
        SceneChange("5.1Saturday[BubbleBath]");
    }

    public void yogaShower() {
        MGettingReady.points += 0; 
        SceneChange("5.2Saturday[Yoga]");
    }

    //Funcs for scene change
    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}
