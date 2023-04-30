using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TueWakeUp : MonoBehaviour
{

    public GameObject dialogueDisplay;
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;
    public static bool boughtCoffee;
    public GameObject text;
    

    // Start is called before the first frame update
    void Start()
    {
        boughtCoffee = false;
        buttonOption1.SetActive(false);
        buttonOption2.SetActive(false);
        dialogueDisplay.SetActive(true);
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

    public void brewCofee() {
        SceneChange("2.2.1Tuesday[HomeBrew]");
    }

    public void buyCoffee() {
        boughtCoffee = true;
        MGettingReady.points -= 2; 
        SceneChange("2.2.2Tuesday[CoffeeShop]");
    }

    //Funcs for scene change
    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }

}