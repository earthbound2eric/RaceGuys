using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockVerticalMove : MonoBehaviour {
    public float minY;
    public float maxY;
    // Use this for initialization
    void Start () {
        minY = transform.position.y-2;
        maxY = transform.position.y+2;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(Time.time * 2, maxY) + minY );// 2f
    }
}
