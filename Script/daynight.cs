using UnityEngine;

public class daynight : MonoBehaviour {

    public float daytime = 10f;
    private float boucle = 1;
    // Update is called once per frame

    void Update() {

        while (boucle == 1) {
            transform.localScale = new Vector3(24f, -6f, 1);
            new WaitForSeconds(daytime);
            transform.localScale = new Vector3(24f, 6f, 1);
            new WaitForSeconds(daytime);

        }
    }
}
