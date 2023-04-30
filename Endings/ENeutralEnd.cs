using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENeutralEnd : MonoBehaviour
{
   public GameObject dialogueDisplay1;
    public GameObject nextButton;
    public GameObject background;
    public GameObject text1;
    public GameObject text2;
    public int counter;
    public AudioSource music;


    // Start is called before the first frame update
        void Start() {
        music.Play();
        counter = 0;
        dialogueDisplay1.SetActive(true);
        nextButton.SetActive(true);
        background.SetActive(true);
        text1 = GameObject.FindWithTag("Text1");
        text2 = GameObject.FindWithTag("Text2");
        text1.SetActive(true);
        text2.SetActive(false);
    }

    public void nextClick() {
        if (counter < 1) {
            nextDialogue();
        }
        else if (counter < 2) {
            SceneChange("Credits");
        }
        counter = counter + 1;
    }

    public void nextDialogue() {
        text1.SetActive(false);
        text2.SetActive(true);
    }
    
    
    //Funcs for scene change
    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}
