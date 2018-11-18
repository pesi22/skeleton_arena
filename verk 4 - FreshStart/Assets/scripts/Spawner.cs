using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject skellaton;
    public float spawnRate = 2f;
    public float nextSpawn = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Instantiate(skellaton, new Vector2(Random.Range(-9.49f, 9.49f), 10f), Quaternion.identity);
        }
    }
}
