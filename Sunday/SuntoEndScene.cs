using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SuntoEndScene : MonoBehaviour
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

    public void SceneChange(){
        SceneManager.LoadScene("YearsLater");
    }
}
