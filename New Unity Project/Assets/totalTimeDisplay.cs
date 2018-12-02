using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class totalTimeDisplay : MonoBehaviour {
    public float currentTime;
    public TextMeshProUGUI timerText;
    // Use this for initialization
    void Start () {
        currentTime = PlayerPrefs.GetFloat("totalTime");
        timerText = GetComponent<TextMeshProUGUI>();
        timerText.text = "Timer: " + (currentTime).ToString("f2");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
