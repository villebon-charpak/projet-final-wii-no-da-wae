using UnityEngine;

public class daynight : MonoBehaviour {
	int i = 1;
	void Start ()	{	}

	void Update()
	{
		if (i == 1000)
		{
			transform.localScale = new Vector3(24f, -6f, 1);
		}
		if (i == 2000)
		{
			transform.localScale = new Vector3(24f, 6f, 1);
			i = 0;
		}
		i += 1;
		//Debug.Log (i);
	}
}
