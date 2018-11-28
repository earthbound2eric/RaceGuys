using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject PauseMenuUI;
	// Use this for initialization
	void Start () {
        resume();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resume();
            } else
            {
                pause(); 
            }
        }
	}
    public void resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void returnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void quitGame()
    {
        Application.Quit();
    }

}
