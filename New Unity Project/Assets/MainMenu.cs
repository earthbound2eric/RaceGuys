using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

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
        SceneManager.LoadScene("Level Select Screen");
    }
}
