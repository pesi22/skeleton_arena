using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerMovement : MonoBehaviour {

    private float speed = 5f;
    private PlayerMotor motor;


    // Use this for initialization
    void Start () {
        motor = GetComponent<PlayerMotor>();
        

    }
	
	// Update is called once per frame
	void Update () {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        Vector3 movHor = transform.right * xMove;
        Vector3 movVer = transform.forward * zMove;

        Vector3 vel = (movHor + movVer).normalized * speed;

        motor.Move(vel);

        //Animator attack
        

    }
}
