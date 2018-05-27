using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	int t = 0;
	int faim = 0;
	// Use this for initialization
	void OnGUI () 
	{
		Event ev = Event.current;
		if (ev.Equals (Event.KeyboardEvent ("l"))) 
		{
			Player.Ressource.gold += 1;
		}
		if (ev.Equals (Event.KeyboardEvent ("m"))) 
		{
			Player.Ressource.Weath += 1;
		}
	}


	// Update is called once per frame
	void Update () {

		if (faim == 2000) 
		{
			Player.Ressource.Weath -= 1;
			if (Player.Ressource.Weath == 0) {
                GameObject.Find("Canvas").GetComponent<PauseMenu>().Restart();

            }
			faim = 0;
		}

		faim += 1;


		if (t == 1000) {
			for (int i = 0; i < Buildings.gold; i++) {
				Player.Ressource.gold += Trading.Ressource.Gold.price;
			}
			for (int i = 0; i < Buildings.weath; i++) {
				Player.Ressource.Weath += Trading.Ressource.Weath.price;
			}
			Player.AliveTmp += 1;
			t=0;
		}
		t += 1;
	}


	
}
