using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject partner;

	void OnCollisionEnter2D(Collision2D obj){
		if (obj.gameObject.tag.Equals ("Ground")) {
			Camera.main.GetComponent<Jump>().canJump = true;
		}
	}
	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.tag.Equals ("Enemy")) {
			Destroy (obj.gameObject);
			GameObject.Find("PrefabInstantiator").GetComponent<Instantiate>().flag = false;
			Invoke ("Teste",2f);
			gameObject.GetComponent<Animator> ().SetTrigger ("HurtAnimation");
			partner.GetComponent<Animator>().SetTrigger ("HelpAnimation");
		}
	}
	void OnCollisionExit2D(Collision2D obj){
		if (obj.gameObject.tag.Equals ("Ground")) {
			Camera.main.GetComponent<Jump>().canJump = false;
		}

	}
	void Teste(){
		GameObject.Find("PrefabInstantiator").GetComponent<Instantiate>().flag = true;
	}
}
