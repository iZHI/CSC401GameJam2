using UnityEngine;
using System.Collections;

public class GunLightScript : MonoBehaviour {
	public float hitdistance;

	void Start() {
		hitdistance = 100.0f;
	}

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, hitdistance)) {
			Destroy(hit.transform.gameObject);
		}
	}
}
