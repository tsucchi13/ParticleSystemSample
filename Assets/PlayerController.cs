using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	float spped=5;
	public GameObject effecter;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (-spped * Time.deltaTime, 0, 0);
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag== "Enemy") {

			Destroy (col.gameObject);
			Instantiate (effecter, this.transform.position, Quaternion.identity);
		}
	}
}