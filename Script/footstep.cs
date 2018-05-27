using UnityEngine;

public class footstep : MonoBehaviour {

    movement_horizontal mh;

	// Use this for initialization
	void Start () {

        mh = GetComponent<movement_horizontal>();
		
	}
	
	// Update is called once per frame
	void Update () {

        AudioSource audio = GetComponent<AudioSource>();

        if (mh.precx != mh.x && audio.isPlaying == false)
        {
            audio.Play();
        }
		
	}
}
