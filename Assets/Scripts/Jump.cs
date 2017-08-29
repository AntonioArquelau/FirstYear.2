using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	private Rigidbody2D rigidBody2DAntonio;
	private Rigidbody2D rigidBody2DJessica;
	private Vector2 force;
	public bool canJump;
	public GameObject antonio;
	public GameObject jessica;

	// Use this for initialization
	void Start () {
		canJump = true;
		rigidBody2DAntonio = antonio.GetComponent<Rigidbody2D> ();
		rigidBody2DJessica = jessica.GetComponent<Rigidbody2D> ();
		force = new Vector2 (0, 350);

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0) && canJump) {
			Debug.Log ("test");
			if (Input.mousePosition.x > 520) {
				rigidBody2DAntonio.AddForce (force);
			} else {
				rigidBody2DJessica.AddForce (force);
			}
		}
	}
}
