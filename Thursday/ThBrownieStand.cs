using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThBrownieStand : MonoBehaviour
{
    public GameObject dialogueDisplay1;
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;
    public static bool bakeSale;
    public GameObject text; 
    

    // Start is called before the first frame update
    void Start() {
        bakeSale = false; 
        buttonOption1.SetActive(false);
        buttonOption2.SetActive(false);
        dialogueDisplay1.SetActive(true);
        nextButton.SetActive(true);
        background.SetActive(true);
        text = GameObject.FindWithTag("Text");
    }

    public void nextClick() {
        text = GameObject.FindWithTag("Text");
        text.SetActive(false);
        nextButton.SetActive(false);
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
    }

    public void brownie() {
        MGettingReady.points += 1; 
        bakeSale = true;
        SceneChange("4.1Thursday[PurchaseBrownie]");
    }

    public void noBrownie() {
        MGettingReady.points += 0; 
        SceneChange("4.2Thursday[NoBrownie]");
    }


    //Funcs for scene change
    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}
