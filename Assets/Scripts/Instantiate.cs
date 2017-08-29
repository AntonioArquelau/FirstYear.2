using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {
	private GameObject prefab;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject remenber1;
	public GameObject remenber2;
	public GameObject remenber3;
	public GameObject remenber4;
	public GameObject remenber5;
	public GameObject remenber6;
	public GameObject obj;

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
		int range1 = (int)Mathf.Round(Random.Range (0, 3));
		if (range1 == 0)
			prefab = enemy1;
		if (range1 == 1)
			prefab = enemy2;
		if (range1 == 2)
			prefab = enemy3;
		
		if (cont % 5 == 0) {
			cont++;
			flag = false;
			if (cont == 6)
				obj = Instantiate (remenber1, new Vector3 (gameObject.transform.position.x, 0, 0), gameObject.transform.rotation);
			if (cont == 11)
				obj = Instantiate (remenber2, new Vector3 (gameObject.transform.position.x, 0, 0), gameObject.transform.rotation);
			if (cont == 16)
				obj = Instantiate (remenber3, new Vector3 (gameObject.transform.position.x, 0, 0), gameObject.transform.rotation);
			if (cont == 21)
				obj = Instantiate (remenber4, new Vector3 (gameObject.transform.position.x, 0, 0), gameObject.transform.rotation);
			if (cont == 26)
				obj = Instantiate (remenber5, new Vector3 (gameObject.transform.position.x, 0, 0), gameObject.transform.rotation);
			if (cont == 31)
				obj = Instantiate (remenber6, new Vector3 (gameObject.transform.position.x, 0, 0), gameObject.transform.rotation);
			
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
