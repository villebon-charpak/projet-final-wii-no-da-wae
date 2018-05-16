using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {
	void OnGUI() {
		Event e = Event.current;
		GameObject cam = GameObject.Find("Main Camera");
		float poscam = cam.transform.position.x;
		double xmap = (e.mousePosition.x*(26+poscam)/810)-13+poscam;
		double ymap = -((e.mousePosition.y * 21/315)-10.5);
		//Debug.Log(e.mousePosition);
		if (e.button == 1)
		{
			//Debug.Log (xmap.ToString()+"   "+ymap.ToString());
		}
		if (e.button == 1 && -4 <= xmap && xmap <= 0 && ymap <= 0){
			//Debug.Log("Right Click");
			cam.transform.position = new Vector3(0f, 0f, 2f);
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
