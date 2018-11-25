using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour {

    // Use this for initialization
    public float minX = 0f;
    public float maxX = 2f;
    //public int blockSpeed=5;
	void Start () {
        minX = transform.position.x;
        maxX = transform.position.x + 3;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(Mathf.PingPong(Time.time, maxX - minX) + minX, transform.position.y);
    }
}
