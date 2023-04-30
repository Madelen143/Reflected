using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TueToWedMorn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialogueDisplay;
    public GameObject nextButton;
    public GameObject background;
    public AudioSource music;


    // Start is called before the first frame update
    void Start() {
        music.Play();
        nextButton.SetActive(true);
        background.SetActive(true);
    }

    public void nextClick() {
        // StartCoroutine(FadeAudioSource.StartFade(music, 3, 0));
        // Invoke("SceneChange", 3);
        SceneChange();
    }

    public void SceneChange() {
        SceneManager.LoadScene("1Wednesday[Wakeup]");
    }
}
