using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1000;
    public float moveX;
    public bool isGrounded;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMove1();
	}
    void PlayerMove1()
    {
        moveX = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") == true && isGrounded==true)
        {
            Jump();
        }
        if(moveX<0.0f&&facingRight==false)
        {
            FlipPlayer();
        }
        else if(moveX>0.0f&&facingRight==true)
        {
            FlipPlayer();
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;
    }
    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="ground")
        {
            isGrounded = true;
        }
    }
}

