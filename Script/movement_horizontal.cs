using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_horizontal : MonoBehaviour {
	float x = 0;
	float precx = 0;
	float speedmodifier = (float)0.1;
	double bord = 29;
	string lien = "Texture/Perso/";
	int i = 1;

	void Start()
	{
		
	}

	void FixedUpdate()
	{

		x = transform.position.x;
		float mv = Input.GetAxis ("Horizontal");
		if ((x < bord && mv > 0) || (x > -bord && mv < 0))
		{
			transform.position += new Vector3 (mv*speedmodifier, 0f, 0f);
		}

		if (precx != x) {
			var result = Resources.Load<Sprite> (lien + i.ToString ());
			GameObject.Find ("PersoTexture").GetComponent<SpriteRenderer> ().sprite = result;

			if (i == 5) {
				i = 1;
			} else {
				i += 1;
			}
		}

		//Debug.Log (x);

		precx = x;
	}
}