using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TueClub : MonoBehaviour
{

    public GameObject dialogueDisplay;
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        buttonOption1.SetActive(false);
        buttonOption2.SetActive(false);
        dialogueDisplay.SetActive(true);
        nextButton.SetActive(true);
        background.SetActive(true);
        text = GameObject.FindWithTag("Text");
    }

    // Update is called once per frame
    public void nextClick(){
        text.SetActive(false);
        nextButton.SetActive(false);
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);       
    }

    public void beachClean(){
        MGettingReady.points += 2;
        SceneChange("3.1Tuesday[Beach]");
    }

    public void amusementPark(){
        MGettingReady.points -= 1;
        SceneChange("3.2Tuesday[AmusementPark]");
    }
    
    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }


}
