using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;

	public SingleJoystick joystick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveAccordingToJoystick ();
	}

	void MoveAccordingToJoystick ()
	{
		var stick = joystick.GetInputDirection ();
		Vector3 newPos = transform.position + stick * speed * Time.fixedDeltaTime;
		newPos.x = Mathf.Clamp (newPos.x, -2,2f);
		newPos.y = Mathf.Clamp(newPos.y, -3f, 3f);

		transform.rotation = Quaternion.Euler (stick.y * 25, stick.x * -45, 0);



		transform.position = newPos;

	}

	void OnTriggerEnter2D(Collider2D collision) {
		//Debug.Log (collision);
	}
}

