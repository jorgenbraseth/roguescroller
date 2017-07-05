using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public GameObject deathExplosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collision) {		
		if (collision.tag == "PlayerShot") {
			Die ();
		}
	}

	void Die(){
		Instantiate (deathExplosion, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
}
