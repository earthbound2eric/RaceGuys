using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Death : MonoBehaviour {
    public bool hasDied;
    public TextMeshProUGUI deathcount;
    public  int numofDeaths;
	// Use this for initialization
	void Start () {
        hasDied = false;
        numofDeaths = PlayerPrefs.GetInt("deaths");
	}
	
	// Update is called once per frame
	void Update () {
        deathcount.text = "Deaths: " + numofDeaths.ToString();
        if (gameObject.transform.position.y<-3)
        {
            
            hasDied = true;
            numofDeaths++;
            PlayerPrefs.SetInt("deaths", numofDeaths);
            deathcount.text = "Deaths: " + numofDeaths.ToString();
        }
        if(hasDied==true)
        {
            SoundManagerScript.PlaySound("playerDeath");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
           
            hasDied = true;
            numofDeaths++;
            PlayerPrefs.SetInt("deaths", numofDeaths);
            deathcount.text = "Deaths: " + PlayerPrefs.GetInt("deaths").ToString();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    //IEnumerator Die()
    //{
        
    //    yield return null;
    //}
}
