using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_horizontal : MonoBehaviour {
	float x=0;
	float speedmodifier = (float)0.1;
	double bordrightmax = 29;
	double bordleftmax = -29;

	void Start()
	{
		transform.position = new Vector3(x, 0f, -3f);
	}
	void FixedUpdate()
	{
		float X = x * speedmodifier;
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (X, 0f, -3f);
		Debug.Log(moveHorizontal);
		if (x <= bordrightmax/speedmodifier && moveHorizontal >= 0) {
			
			x = moveHorizontal + x;
			transform.position = movement;


		} else if (x >= bordleftmax/speedmodifier && moveHorizontal <= 0) {
			
			x = moveHorizontal + x;
			transform.position = movement;

		} else if (x > bordleftmax/speedmodifier && x < bordrightmax/speedmodifier) {
			
			x = moveHorizontal + x;
			transform.position = movement;

		}

		//Debug.Log (x);
		//-----------------------------------------------------------------------------
		//--		Le x de la position est 10x trop grand mais OSEF ca marche       --
		//-----------------------------------------------------------------------------
	}
}