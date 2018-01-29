using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasMy : MonoBehaviour {

    public GameObject textOver;
    public GameObject beginButton;
    public GameObject nextButton;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!GameOver.isActive)
        {
            textOver.SetActive(true);
            beginButton.SetActive(true);
            nextButton.SetActive(true);
        }
	}
    public void GameStart()
    {
        textOver.SetActive(false);
        beginButton.SetActive(false);
        nextButton.SetActive(false);
        GameOver.isActive = true;
        GameOver.score = 0;
        Application.LoadLevel("YOUXI");
    }
    public void NextGame()
    {
        Application.LoadLevel("GitHub");
    }

}
