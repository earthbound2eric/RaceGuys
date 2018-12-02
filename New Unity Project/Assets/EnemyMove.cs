using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    
    private bool facingRight = false;       
    Vector3 lastposition;
    Vector3 deltax;
   
    // Use this for initialization
    void Start () {
        lastposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        deltax = transform.position - lastposition;
        float test = deltax.x;
        float test2 = lastposition.x;

        if (test > 0 && facingRight == false)
        {
            FlipPlayer();
        }
        else if (test < 0 && facingRight == true)
        {
            FlipPlayer();
        }
        lastposition = transform.position;
    }
    
   void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
