using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//purpose: character controller
//usage: to put on 

public class Player : MonoBehaviour
{
    Rigidbody2D myRigidbody;// a reference to the rigidbody
    // Start is called before the first frame update

    float inputHorizontal;
    bool isJumping;

    public float moveSpeed = 15f, jumpPower = 25f;
    public bool isGrounded; //set by platformer grounded trigger

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    //every rendering frame
    void Update()
    {
        // Move left and right
        inputHorizontal = Input.GetAxis("Horizontal");//-1 if left. +1 if right

        if (Global.trigger1 == 1)
        {
            if (Input.GetButtonDown("Jump"))
            {
                isJumping = true;
            }
        }

        if (Global.trigger1 ==0){
            if (Input.GetButtonDown("Jump") && isGrounded) {
                isJumping = true;
            }
        }

        if (Global.health <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();


        }

    }


    //every physics 
    void FixedUpdate() {
        myRigidbody.velocity = new Vector2(inputHorizontal * moveSpeed, myRigidbody.velocity.y);

        if (isJumping) {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpPower);
            isJumping = false;
        }
    }
}
