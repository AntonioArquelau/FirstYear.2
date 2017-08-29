using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemenberBehaviour : MonoBehaviour {
	public int cont;
	void Start(){
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-7, 0);
	}
	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.tag.Equals ("Destroy")) {
			GameObject.Find("PrefabInstantiator").GetComponent<Instantiate>().flag = true;
			Destroy (gameObject);
		}
		if (obj.gameObject.tag.Equals ("Stop")) {
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		}

	}
	void OnMouseDown(){
		Debug.Log ("teste");
		if (cont >= 30)
			Application.LoadLevel ("Main");
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-7, 0);
	}
}
