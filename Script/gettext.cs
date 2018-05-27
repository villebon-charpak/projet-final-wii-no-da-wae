using UnityEngine.UI;
using UnityEngine;

public class gettext : MonoBehaviour {

    public string playername = "Dieu";

    void Start()
        {
            var input = gameObject.GetComponent<InputField>();
            var se = new InputField.SubmitEvent();
            se.AddListener(SubmitName);
            input.onEndEdit = se;

            //or simply use the line below, 
            //input.onEndEdit.AddListener(SubmitName);  // This also works
        }

    public void SubmitName(string arg0)
    {
        //Debug.Log(arg0);
        playername = arg0;
    }

    public string getname()
    {
        return playername;
    }




}
