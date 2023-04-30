using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MGettingReady : MonoBehaviour {
    public int counter = 0;
    public GameObject buttonOption1;
    public GameObject buttonOption2;
    public GameObject nextButton;
    public GameObject background;
    public AudioSource showerSound;
    public static int points;

    //Start the scene with text and no buttons visable yet
    void Start() {
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
        nextButton.SetActive(false);
        background.SetActive(true);
        points = 0;
    }


    public void noShowerOption() {
        points += 2; 
        nextScene();
    }

    public void quickShowerOption() {
        points += 1;
        showerSound.Play();
        // StartCoroutine(FadeObject.FadeOutObject(buttonOption1));
        StartCoroutine(FadeAudioSource.StartFade(showerSound, 4, 0));
        Invoke("nextScene", 4);
    }
   
    public void nextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

} 
