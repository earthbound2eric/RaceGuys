using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour {
    void Start()
    {
        
    }
    public void LoadLevelOne()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void LoadLevelThree()
    {
        SceneManager.LoadScene("Level_3");
    }
    public void LoadLevelFour()
    {
        SceneManager.LoadScene("Level_4");
    }
    public void LoadLevelFive()
    {
        SceneManager.LoadScene("Level_5");
    }
    public void LoadLevelSix()
    {
        SceneManager.LoadScene("Level_6");
    }


}
