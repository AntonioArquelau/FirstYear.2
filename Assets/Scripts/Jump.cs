using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	private Rigidbody2D rigidBody2D;
	private Vector2 force;
	private bool canJump;
	// Use this for initialization
	void Start () {
		rigidBody2D = gameObject.GetComponent<Rigidbody2D> ();
		force = new Vector2 (0, 250);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && canJump) {
			rigidBody2D.AddForce(force);
		}
	}

	void OnCollisionEnter2D(Collision2D obj){
		if (obj.gameObject.tag.Equals ("Ground")) {
			canJump = true;
		}
				
	}
	void OnCollisionExit2D(Collision2D obj){
		if (obj.gameObject.tag.Equals ("Ground")) {
			canJump = false;
		}

	}
}
