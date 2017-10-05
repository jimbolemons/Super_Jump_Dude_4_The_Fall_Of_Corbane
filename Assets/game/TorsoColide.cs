using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoColide : MonoBehaviour {
	public AudioClip hurt;
	public AudioClip powerup;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.tag == "Enemy")
        {
            if (Example2Player.hasPowerUp == false)
            {
                print("player is ded");
            }
            if (Example2Player.hasPowerUp == true)
            {
                Example2Player.hasPowerUp = false;
                Destroy(coll.gameObject);
				AudioSource.PlayClipAtPoint(hurt, transform.position);
            }

        }
        if (coll.gameObject.tag == "PowerUp")
        {
            Example2Player.hasPowerUp = true;
            Destroy(coll.gameObject);
			AudioSource.PlayClipAtPoint(powerup, transform.position);
        }


    }
    void OnCollisionExit2D(Collision2D coll)
    {
        


    }
}
