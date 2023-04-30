using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SErrandDec : MonoBehaviour
{
    
    public GameObject dialogueDisplay;
    public GameObject nextButton;
    public GameObject background;


    void Start() {
        dialogueDisplay.SetActive(true);
        nextButton.SetActive(true);
        background.SetActive(true);
    }

    public void nextClick() {
        if (ThBrownieStand.bakeSale == true) {
            SceneChange("3Saturday[Coupon]");
        }
        else {
            SceneChange("4.0Saturday[Coupon]");
        }
    }


    //Funcs for scene change
    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}
