using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isgrounded : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            Example2Player.isGrounded = true;
        }


    }
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            Example2Player.isGrounded = false;
            Example2Player.canJump = true;
        }


    }
}
