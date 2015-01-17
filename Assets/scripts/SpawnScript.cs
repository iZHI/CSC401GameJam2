using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject enemy;
	public int maxEnemy;
	
	private GameObject[] spawnpoints;
	private float lastEnemySpawnTime;
	
	// Use this for initialization
	void Start () {
		lastEnemySpawnTime = 0;
		spawnpoints = GameObject.FindGameObjectsWithTag("spawnpoint");
	}
	
	// Update is called once per frame
	void Update () {
		
		// Spawn enemy if not enough on screen
		float diff = Time.time - lastEnemySpawnTime;
		
		if (diff > 2.0F && GameObject.FindGameObjectsWithTag ("enemy").Length < maxEnemy) {
			Instantiate (enemy, spawnpoints[Random.Range(0, 14)].transform.position, Quaternion.identity);
			lastEnemySpawnTime = Time.time;
		}
	}
}
