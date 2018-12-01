using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startGame : MonoBehaviour {
    private float time = 0.0f;
    public Text timer;
    public int minutes;
    public int seconds;
    public string timerString;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        minutes = (int)(time % 60);
        seconds = (int)(time / 60)%60;
        //timer.GetComponent.guiText = time.ToString();
        timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
        //timer.text = timerString;
    }

}
