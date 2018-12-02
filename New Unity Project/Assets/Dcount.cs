using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Dcount : MonoBehaviour {

    public int dCount;
    public TextMeshProUGUI deathText;
    // Use this for initialization
    void Start()
    {
        dCount = PlayerPrefs.GetInt("deaths");
        deathText = GetComponent<TextMeshProUGUI>();
        deathText.text = "Total Deaths: " + (dCount);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
