using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class froggerman : MonoBehaviour {
    bool iG = true;
    public int playerSpeed = 10;
    public int playerJumpPower = 200;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (iG == true)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(playerSpeed, 0);
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * (playerJumpPower - gameObject.GetComponent<Rigidbody2D>().velocity.y));
            iG = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            iG = true;
        }

    }
}
