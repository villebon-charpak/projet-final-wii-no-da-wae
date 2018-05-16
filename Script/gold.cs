using UnityEngine;
using UnityEngine.UI;

public class gold : MonoBehaviour {

    public Transform player;
    public Text goldnumber;
    public Text wheatnumber;
	
	// Update is called once per frame
	void Update () {
        goldnumber.text = player.position.x.ToString();
        wheatnumber.text = "lolilol";
               
	}
}
