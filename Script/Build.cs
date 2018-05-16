using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour {


	bool Allreadybuilded = false;
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
		
	}

	// Update is called once per frame
	void OnGUI () {
		GameObject play = GameObject.Find("PersoTexture");
		float X = play.transform.position.x;
		float Y = play.transform.position.y;
		Event ev = Event.current;
		//double X = ev.mousePosition.x;
		//double Y = ev.mousePosition.y;
		int clic = ev.button;
		float Posx = this.transform.position.x;
		float Posy = this.transform.position.y;
		Debug.Log (X);
		Debug.Log (Posx);
		if ( ev.Equals(Event.KeyboardEvent("a")) && Posx-2 <= X && X <= Posx+ 2 && Y <= Posy + 1 && Posy -1 <= Y && Allreadybuilded == false){
			Debug.Log ("LOOOOOOOL");
			var MonObjet = creer("Bat1","Texture/Bat/FUCK IT");
			deplacer (MonObjet, Posx, Posy + 1.6f, -1f);
			Allreadybuilded = true;
		}
		else if (ev.Equals(Event.KeyboardEvent("z")) && Posx-2 <= X && X <= Posx+ 2 && Y <= Posy + 1 && Posy -1 <= Y && Allreadybuilded == false){
			Debug.Log ("LOOOOOOOL");
			var MonObjet = creer("Bat1","Texture/Bat/maison");
			deplacer (MonObjet, Posx, Posy + 2f, -1f);
			Allreadybuilded = true;
		}
	}
}
