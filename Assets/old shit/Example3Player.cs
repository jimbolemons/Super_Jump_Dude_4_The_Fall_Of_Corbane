using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example3Player : MonoBehaviour {

    CharacterController pawn;
    public float speedMove = 5;
    public float speedTurn = 180;

    Vector3 velocity = Vector3.zero;
    public float impulseJump = 5;
    public float baseGravityMultiplier= 5;
    public float jumpGravityMultiplier = 2.5f;

    //Prefessionals recommend with jumping
    //After a player hits the peak increase gravity
    //Or as soon as a player lets go of the button increase gravity




    // Use this for initialization
    void Start () {
        pawn = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //pawn.Move();
        //Prototype Player movement
        //Add a unique way of moving around the environment
        float axisV = Input.GetAxis("Vertical");
        float axisH = Input.GetAxis("Horizontal");
        transform.Rotate(0, axisH * speedTurn * Time.deltaTime, 0);
        Vector3 move = transform.forward * axisV * speedMove;
        bool isJumping = false;

        velocity.x = move.x;
        velocity.z = move.z;

        float gravityScale = baseGravityMultiplier;
        if (pawn.isGrounded)
        {
            velocity.y = 0;
            if (Input.GetButtonDown("Jump"))
            {
                isJumping = true;
                velocity.y = impulseJump;
                gravityScale = jumpGravityMultiplier;
            }
        }
        else
        {
            if (Input.GetButton("Jump"))
            {
               if(isJumping  && velocity.y > 0) gravityScale = jumpGravityMultiplier;
            }else
            {
                isJumping = false;
            }
        }
        velocity += Physics.gravity *Time.deltaTime * gravityScale; 
        pawn.Move(velocity*Time.deltaTime);
        // pawn.SimpleMove(transform.forward * axisV*speedMove);
        //^Simple move is awesome and is easy to implement
        /*Vector3 move = transform.forward * axisV * speedMove;

        if (Input.GetButtonDown("Jump"))
        {
            move.y += 10;
        }

        pawn.SimpleMove*/
        //^This is a really niave approach there is a better way to do this^
	}
}
