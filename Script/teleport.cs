using UnityEngine;

public class teleport : MonoBehaviour {

    Vector3 myvector;

	// Update is called once per frame
	void Update () {
        AudioSource dansel = GetComponent<AudioSource>();
        if (Input.GetKeyDown(KeyCode.H)) { transform.position = new Vector3(2.772f,-0.75f,0); dansel.Play(); }
        
	}
}
