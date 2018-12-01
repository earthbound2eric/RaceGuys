using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Death : MonoBehaviour {
    public bool hasDied;
	// Use this for initialization
	void Start () {
        hasDied = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y<-3)
        {
            hasDied = true;

        }
        if(hasDied==true)
        {
            StartCoroutine("Die");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    IEnumerator Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        yield return null;
    }
}
