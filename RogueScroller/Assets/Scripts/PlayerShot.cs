using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour {

	public float speed = 2f;

	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3 (0, speed*Time.fixedDeltaTime, 0);
	}

	void OnBecameInvisible() {
		Destroy (gameObject);
	}

	void OnTriggerEnter2D(Collider2D collision) {
		//Debug.Log (collision);
	}

}
