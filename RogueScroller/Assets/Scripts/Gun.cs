using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	public PlayerShot shotType;

	public float shotInterval = 1;
	private float timeUntilShot;

	// Use this for initialization
	void Start () {
		timeUntilShot = shotInterval;
	}
	
	// Update is called once per frame
	void Update () {
		timeUntilShot -= Time.fixedDeltaTime;
		if (timeUntilShot<= 0) {
			PlayerShot newshot = Instantiate (shotType, transform.position, transform.rotation);

			shotType.transform.parent = null;
			timeUntilShot = shotInterval;
		}

	}
}
