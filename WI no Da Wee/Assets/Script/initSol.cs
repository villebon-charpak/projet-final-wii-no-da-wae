using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initSol : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		GameObject sol = new GameObject();
		sol.AddComponent<SpriteRenderer>();
		sol.name = "Sol";
		var result = Resources.Load<Sprite>("Sol_Terre");
		sol.GetComponent<SpriteRenderer> ().sprite = result;
		sol.transform.position = new Vector3(0f,-5.3f,0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
