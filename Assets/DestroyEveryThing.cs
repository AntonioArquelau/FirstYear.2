using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEveryThing : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D obj){
		Destroy (obj.gameObject);
	}
}
