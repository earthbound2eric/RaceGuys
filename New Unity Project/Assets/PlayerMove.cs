using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerMove : MonoBehaviour {
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 200;
    public float moveX;
    public bool isGrounded;
    public float dVelocity;
    bool canPlayerMove = true;
    public TextMeshProUGUI youWinText;
    // Use this for initialization
    void Start() {
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update() {

        if (canPlayerMove)
        {
            PlayerMove1();
        }
    }
    void PlayerMove1()
    {
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") == true && isGrounded == true)
        {
            Jump();
        }
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }


        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        
    }
    void Jump()
    {
        SoundManagerScript.PlaySound("playerJump");
        transform.parent = null;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(playerSpeed, 0);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * (playerJumpPower - gameObject.GetComponent<Rigidbody2D>().velocity.y));
        isGrounded = false;
        playerJumpPower = 200;

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "jumpAgain")
        {
            SoundManagerScript.PlaySound("playerGem");
            Destroy(collider.gameObject);
            isGrounded = true;
        }
        else if (collider.gameObject.tag == "spring")
        {
            isGrounded = false;
            playerJumpPower = 300;
            Jump();
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
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "jumpAgain")
        {
            isGrounded = true;
            transform.parent = null;
        } else if (collision.gameObject.tag == "Move Block" || collision.gameObject.tag == "MoveVerticalBlock") {
            isGrounded = true;
            transform.parent = collision.transform;
        }
        if (collision.gameObject.tag == "finish flag")
        {
            SoundManagerScript.PlaySound("playerWin");
            youWinText.gameObject.SetActive(true);
            canPlayerMove = false;
            Invoke("win", 2.35f);
        }
    }
    private void win()
    {
        
        Time.timeScale = 0f;
        int currentLevel = int.Parse(SceneManager.GetActiveScene().name[6].ToString());
        if (currentLevel > PlayerPrefs.GetInt("levelPassed")){
            PlayerPrefs.SetInt("levelPassed", currentLevel);
        }
        youWinText.gameObject.SetActive(false);
        SceneManager.LoadScene("Level Select Screen");
    }
}

