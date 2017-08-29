﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {
	public GameObject prefab;
	public GameObject remenber;
	public float delay;
	private float range;
	public bool flag;
	private int cont = 1;
	// Use this for initialization
	void Start () {
		flag = true;
		InvokeRepeating ("InstantiatePrefab", 0, delay);
	}
	
	// Update is called once per frame
	void InstantiatePrefab () {
		if (cont % 5 == 0) {
			cont++;
			flag = false;
			GameObject obj = Instantiate (remenber, new Vector3 (gameObject.transform.position.x, 0, 0), gameObject.transform.rotation);
			obj.GetComponent<RemenberBehaviour> ().cont = cont;
		}
		if (flag) {
			range = Mathf.Round (Random.Range (0, 2));
			if (range == 0) {
				Instantiate (prefab, new Vector3 (gameObject.transform.position.x, 1, 0), gameObject.transform.rotation);
			} else {
				Instantiate (prefab, new Vector3 (gameObject.transform.position.x, -3.5f, 0), gameObject.transform.rotation);
			}
			cont++;
		}
	}
}
