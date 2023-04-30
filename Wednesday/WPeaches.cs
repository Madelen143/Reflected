using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WPeaches : MonoBehaviour
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

    public void morePeaches() {
        MGettingReady.points -= 1; 
        SceneChange("7.1Wednesday[MorePeaches]");
    }

    public void normalPeaches() {
        MGettingReady.points += 1; 
        SceneChange("7.2Wednesday[SamePeaches]");
    }

     public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}
