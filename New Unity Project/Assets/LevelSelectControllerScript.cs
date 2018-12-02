using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectControllerScript : MonoBehaviour {
    public Button LevelOneButton, LevelTwoButton, LevelThreeButton, LevelFourButton, LevelFiveButton, LevelSixButton;
    int levelPassed;
    // Use this for initialization
    void Start () {
        levelPassed = PlayerPrefs.GetInt("levelPassed");
        LevelTwoButton.enabled = false;
        LevelThreeButton.enabled = false;
        LevelFourButton.enabled = false;
        LevelFiveButton.enabled = false;
        LevelSixButton.enabled = false;
        switch (levelPassed)
        {
            case 1:
                LevelTwoButton.enabled = true;
                break;
            case 2:
                LevelTwoButton.enabled = true;
                LevelThreeButton.enabled = true;
                break;
            case 3:
                LevelTwoButton.enabled = true;
                LevelThreeButton.enabled = true;
                LevelFourButton.enabled = true;
                break;
            case 4:
                LevelTwoButton.enabled = true;
                LevelThreeButton.enabled = true;
                LevelFourButton.enabled = true;
                LevelFiveButton.enabled = true;
                break;
            case 5:
                LevelTwoButton.enabled = true;
                LevelThreeButton.enabled = true;
                LevelFourButton.enabled = true;
                LevelFiveButton.enabled = true;
                LevelSixButton.enabled = true;
                break;
            case 6:
                SceneManager.LoadScene("Win");
                LevelTwoButton.enabled = true;
                LevelThreeButton.enabled = true;
                LevelFourButton.enabled = true;
                LevelFiveButton.enabled = true;
                LevelSixButton.enabled = true;
                
                break;
            default:
                LevelTwoButton.enabled = false;
                LevelThreeButton.enabled = false;
                LevelFourButton.enabled = false;
                LevelFiveButton.enabled = false;
                LevelSixButton.enabled = false;
                break;
        }
    }
    public void returnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
