using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockVerticalMove : MonoBehaviour {
    public float minX = 0f;
    public float maxX = 2f;
    // Use this for initialization
    void Start () {
        minX = transform.position.y;
        maxX = transform.position.y + 2;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(Time.time, maxX) - minX / 2f);
    }
}
