using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {
	public GameObject prefab;
	public float delay;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("InstantiatePrefab", 0, delay);
	}
	
	// Update is called once per frame
	void InstantiatePrefab () {
		Instantiate (prefab);
	}
}
