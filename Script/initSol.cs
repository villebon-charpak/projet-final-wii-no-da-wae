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
	void deplacer(GameObject obj,float x = 0f,float y = 0f,float z=0f)
	{
		obj.transform.position += new Vector3(x,y,z);
	}

	void toutlesol()
	{
		int prec = 0;
		for (int i = -1 * ((int)bors/4 + 3); i < (int)bors/4 + 3; i++)
		{
			string name = string.Concat("Sol",i.ToString());
			string source = "";
			if (Random.Range(0,2) == 0)
			{
				source = "Texture/Sol/pierre";
				if (prec == 1)
				{
					string tmp = string.Concat ("liaison", i.ToString ());
					var liaison = creer (tmp, "Texture/Transition/TerrePierre");
					deplacer (liaison, 4 * i+0.157f, -1.053f,-0.1f);
				}
				var terre = creer (name,source);
				deplacer (terre, 2+4*i,-1);
				prec = 0;
			}
			else
			{
				source = "Texture/Sol/terre";
				if (prec == 0)
				{
					string tmp = string.Concat ("liaison", i.ToString ());
					var liaison = creer (tmp, "Texture/Transition/PierreTerre");
					deplacer (liaison, 4 * i, -1.032f,-0.1f);
				}
				var terre = creer (name,source);
				deplacer (terre, 2+4*i,-0.95f);
				prec = 1;
			}


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

	}

	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
