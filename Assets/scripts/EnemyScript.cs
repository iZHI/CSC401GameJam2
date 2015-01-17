using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public int senseDistance;
	public int stalkDistance;
	public int chaseDistance;
	public int huntDistance;
	
	public float senseSpeed;
	public float stalkSpeed;
	public float chaseSpeed;
	public float huntSpeed;
	
	private GameObject player;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt (player.transform);
			
		float distance = Vector3.Distance (player.transform.position, transform.position);
		if (distance <= huntDistance) {
			transform.position += transform.forward * huntSpeed * Time.deltaTime;
		} else if (distance <= chaseDistance) {
			transform.position += transform.forward * chaseSpeed * Time.deltaTime;
		} else if (distance <= stalkDistance) {
			transform.position += transform.forward * stalkSpeed * Time.deltaTime;
		} else if (distance <= senseDistance) {
			transform.position += transform.forward * senseSpeed * Time.deltaTime;
		} else {
			// Don't move
		}
	}

	void Die() {
		this.gameObject.SetActive (false);
		Destroy (this.gameObject);
	}

}
