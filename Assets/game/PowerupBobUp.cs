using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupBobUp : MonoBehaviour {

	bool Upbound;
	public Vector3 newpos;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Upbound) {
			newpos.y += speed;
			if (newpos.y > -3.2) {
			
				Upbound = false;
			
			}
		
		
		
		} else if (!Upbound) {
		
			newpos.y -= speed;
			if (newpos.y < -3.7) {

				Upbound = true;

			}
		
		}

		transform.position = newpos;

		
	}
}
