using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AdjustSound : MonoBehaviour {

    // Use this for initialization
    public Slider volumeSlider;
    public AudioSource volumeAudio;
    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Svalue");
    }
    // Update is called once per frame
    void Update () {
        
        volumeAudio.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("Svalue", volumeSlider.value);
	}   
   

}
