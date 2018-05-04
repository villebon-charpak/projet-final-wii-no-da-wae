using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_horizontal : MonoBehaviour {
	float x=0;
	void Start()
	{
		transform.position = new Vector3(x, -2.5f, -3f);
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (x*0.1f, -2.5f, -3f);
		x = moveHorizontal+ x;
		transform.position = movement;

	}
}
