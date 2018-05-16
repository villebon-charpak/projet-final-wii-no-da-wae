using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour {

	GameObject creer(string nom,string lien)
	{
		GameObject sol = new GameObject();
		sol.AddComponent<SpriteRenderer>();
		sol.name = nom;
		var result = Resources.Load<Sprite>(lien);
		sol.GetComponent<SpriteRenderer> ().sprite = result;
		return sol;
	}
	void deplacer(GameObject obj,float x = 0f,float y = 0f,float z=0f)
	{
		obj.transform.position += new Vector3(x,y,z);
	}
	// Use this for initialization
	void Start () {
		float Posx = this.transform.position.x;
		float Posy = this.transform.position.y;	
		var MonObjet = creer("Bat1","Texture/Bat/FUCK IT");
		deplacer (MonObjet, Posx, Posy, -1.25f);
	}
	
	// Update is called once per frame
	void Update () {
		Event e = Event.current;
		double xmap = e.mousePosition.x;
		double ymap = e.mousePosition.y ;
		if (e.button == 1 && -2 <= xmap && xmap <= 2 && ymap <= 1 && 1 <= ymap){
			Debug.Log ("LOOOOOOOL");
			float Posx = this.transform.position.x;
			float Posy = this.transform.position.y;	
			var MonObjet = creer("Bat1","Texture/Bat/FUCK IT");
			deplacer (MonObjet, Posx, Posy, -1.25f);
		}
	}
}
