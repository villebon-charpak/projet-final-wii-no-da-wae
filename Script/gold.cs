using UnityEngine;
using UnityEngine.UI;

public class gold : MonoBehaviour {

    gettext gt;

    public Transform player;
    public Text goldnumber;
    public Text wheatnumber;
    public Text Playername;

    private void Start()
    {
       // gt = GameObject.Find("InputField").GetComponent<gettext>();
    }

    void Update ()
    {
        goldnumber.text =  Player.Ressource.gold.ToString();
        wheatnumber.text =  Player.Ressource.Weath.ToString();
        gt = GameObject.Find("InputField").GetComponent<gettext>();
        Playername.text = gt.getname();
	}
}
