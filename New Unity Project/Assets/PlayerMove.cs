using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 200;
    public float moveX;
    public bool isGrounded;
    public float dVelocity;
    

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
        
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(playerSpeed, 0);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * (playerJumpPower - gameObject.GetComponent<Rigidbody2D>().velocity.y));
        isGrounded = false;
        playerJumpPower = 200;

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Candle")
        {
            Destroy(collider.gameObject);  
            isGrounded = true;
        }
        else if(collider.gameObject.name == "Wood")
        {
            playerJumpPower = 300;
            Jump();
            
        }
        else if(collider.gameObject.tag=="Move Block")
        {                      
           
        }
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
        if (collision.gameObject.tag =="ground" || collision.gameObject.tag == "jumpAgain"||collision.gameObject.tag=="Move Block")
        {
            isGrounded = true;

        }
       
        
    }
}

