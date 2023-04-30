using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCoupon : MonoBehaviour
{
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;


    //Start the scene with text and no buttons visable yet
    void Start() {  
        nextButton.SetActive(false);
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
        background.SetActive(true);
    }

    public void farmersMarket(){
        MGettingReady.points += 1; 
        SceneChange("4.1Saturday[FarmersMarket]");
    }

    public void groceryStore() {
        MGettingReady.points += 0; 
        SceneChange("4.2Saturday[SuperMarket]");
    }

    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}
