using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void Start()
    {
        Time.timeScale = 0f;
    }
	public void PlayGame()
    {
        if (PlayerPrefs.GetInt("levelPassed") != 0)
        {
            SceneManager.LoadScene("Level Select Screen");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        PlayerPrefs.SetInt("levelPassed", 6);
        PlayerPrefs.SetInt("deaths", 0);
        PlayerPrefs.SetFloat("totalTime", 0);
        SceneManager.LoadScene("Level Select Screen");
    }
}
