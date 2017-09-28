using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

    Rigidbody2D body;
    public float impulseJump;
    public float torqueScaler;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         faceMouse();



        if (Input.GetMouseButtonDown(0))
        {

            if (Example2Player.isGrounded == false)
            {
                if (Example2Player.canJump == true) { 
                body.AddForce(transform.up * impulseJump, ForceMode2D.Impulse);
                    Example2Player.canJump = false;
            }
        }
            
        }





    }
    void faceMouse() {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
            );

        transform.up = direction;


    }
}
