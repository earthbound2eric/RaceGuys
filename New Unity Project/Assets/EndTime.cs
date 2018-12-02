using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndTime : MonoBehaviour {

    public float currentTime;
    public TextMeshProUGUI timerText;
    // Use this for initialization
    void Start()
    {
        currentTime = PlayerPrefs.GetFloat("totalTime");
        timerText = GetComponent<TextMeshProUGUI>();
        timerText.text = "Total Time: " + (currentTime).ToString("f2")+" sec";
    }

    // Update is called once per frame
    void Update () {
		
	}
}
