using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initSol : MonoBehaviour {


	float bors = 30;



	GameObject creer(string nom,string lien)
	{
		GameObject sol = new GameObject();
		sol.AddComponent<SpriteRenderer>();
		sol.name = nom;
		var result = Resources.Load<Sprite>(lien);
		sol.GetComponent<SpriteRenderer> ().sprite = result;
		return sol;
	}
	void deplacer(GameObject obj,float x,float y)
	{
		obj.transform.position += new Vector3(x,y,0f);
	}

	void toutlesol()
	{
		for (int i = -1 * ((int)bors/4 + 3); i < (int)bors/4 + 3; i++)
		{
			string source = "Texture/Sol/terre";
			string name = string.Concat("Sol",i.ToString());
			var terre = creer (name,source);
			deplacer (terre, 2+4*i,-1);
		}
	}

	void fence()
	{
		float ytranslate = (float)-0.5;
		string source = "Texture/fence";
		string nameD = "fenceD";
		string nameG = "fenceG";
		var FD = creer (nameD,source);
		var FG = creer (nameG,source);
		deplacer (FD,   bors,ytranslate);
		deplacer (FG,-1*bors,ytranslate);
	}
	
	void Start ()
	{
		
		toutlesol ();
		fence ();

		var ob = GameObject.Find("Init").GetComponent<BuildScript>();
	}

	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
