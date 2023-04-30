using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TueCompostTrash : MonoBehaviour
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
        buttonOption1.SetActive(false);
        buttonOption2.SetActive(false);
        dialogueDisplay.SetActive(true);
        nextButton.SetActive(true);
        background.SetActive(true);
        text = GameObject.FindWithTag("Text");
    }

    // Update is called once per frame
    public void nextClick() {
        text.SetActive(false);
        nextButton.SetActive(false);
        buttonOption1.SetActive(true);
        buttonOption2.SetActive(true);
    }

    public void compost() {
        MGettingReady.points += 1;
        SceneChange();
    }

    public void trash() {
        MGettingReady.points -= 1;
        SceneChange();
    }

    public void SceneChange() {
        SceneManager.LoadScene("3.0Tuesday[Club]");
    }

}
