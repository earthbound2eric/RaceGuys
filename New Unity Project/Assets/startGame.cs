using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class startGame : MonoBehaviour {
    public float time;
    public TextMeshProUGUI timerText;
    public double currentTime;
    // Use this for initialization
    void Start () {
        currentTime = PlayerPrefs.GetFloat("totalTime", time);
        time = PlayerPrefs.GetFloat("totalTime", time);
        timerText = GetComponent<TextMeshProUGUI>();
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime * (01.00f);
        PlayerPrefs.SetFloat("totalTime", time);
        timerText.text = "Timer: " + time.ToString("f2"); 
    }

}
