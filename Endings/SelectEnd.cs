using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectEnd : MonoBehaviour
{
     public GameObject dialogueDisplay1;
    public GameObject nextButton;
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        dialogueDisplay1.SetActive(true);
        nextButton.SetActive(true);
        background.SetActive(true);
    }


    public void SceneSelection() {
        if (MGettingReady.points >= -17 & MGettingReady.points <= 0 ) {
            SceneChange("WorstEnding");
        }
        else if (MGettingReady.points >= 3 & MGettingReady.points <= 11 ) {
            SceneChange("NeutralEnding");
        }
        else {
            SceneChange("BestEnding");
        }
    }
    


    public void SceneChange(string scene){
        SceneManager.LoadScene(scene);
    }
}
