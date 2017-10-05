using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2Player : MonoBehaviour {
    static public bool isGrounded = false;
    static public bool canJump = false;
    static public bool hasPowerUp = true;
    Rigidbody2D body;
    WheelJoint2D wheel;
    public float motorSpeed;
    public float impulseJump;
	public AudioClip jump;
	public Vector3 position;

    // Use this for initialization
    void Start () {
        wheel = GetComponent<WheelJoint2D>();
        body = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float axisH = Input.GetAxis("Horizontal");

        //float increase = axisH * 300;

        JointMotor2D motor = wheel.motor;
        //motor.motorSpeed = axisH *  -1 * motorSpeed;
        motor.motorSpeed = -axisH * motorSpeed;
        wheel.motor = motor;
        
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded) { 
            body.AddForce(transform.up * impulseJump, ForceMode2D.Impulse);
				AudioSource.PlayClipAtPoint(jump, transform.position);
                  }

        }
    }
   

    public void TakeDamage()
    {
        print("I'm Taking damage");
    }
}
