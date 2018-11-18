using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai_sword_hit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
