using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagerForGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playGame() {
        Debug.Log("Play Game Loaded");
        SceneManager.LoadScene("SimulationGame");
    }

    public void Intructions()
    {
        Debug.Log("Intructions Loaded");
        SceneManager.LoadScene("Intructions");
    }

    public void Menu()
    {
        Debug.Log("Menu  Loaded");
        SceneManager.LoadScene("menu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
