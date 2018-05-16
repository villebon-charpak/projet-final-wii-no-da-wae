using UnityEngine;

public class daynight : MonoBehaviour {
	int i = 1;
	void Start ()	{	}

	void Update()
	{
		if (i == 100)
		{
			transform.localScale = new Vector3(24f, -6f, 1);
		}
		if (i == 200)
		{
			transform.localScale = new Vector3(24f, 6f, 1);
			i = 0;
		}
		i += 1;
		//Debug.Log (i);
	}
}
