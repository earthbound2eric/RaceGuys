using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    // Use this for initialization
    public static AudioClip playerDeath;
    public static AudioClip playerJump;
    public static AudioClip underwater;
    public static AudioClip playerWin;
    public static AudioClip playerGem;
    static AudioSource audioSrc;

    void Start()
    {
        underwater = Resources.Load<AudioClip>("underwater");
        
        playerJump = Resources.Load<AudioClip>("playerJump");
        playerWin = Resources.Load<AudioClip>("playerWin");
        playerGem = Resources.Load<AudioClip>("playerGem");
        audioSrc = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {            
               
            case "playerJump":
                audioSrc.PlayOneShot(playerJump);
                break;
            case "playerWin":
                audioSrc.PlayOneShot(playerWin);
                break;
            case "playerGem":
                audioSrc.PlayOneShot(playerGem);
                break;
            case "underwater":
                audioSrc.PlayOneShot(underwater);
                break;
        }

    }

}
