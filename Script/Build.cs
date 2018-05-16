using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour {
	void Onclick (){
		GameObject cam = GameObject.Find("Main Camera");
		cam.transform.position = new Vector3(0f, 0f, -1f);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
