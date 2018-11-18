using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    //Script sem leyfir notanda að líta í kringum sig með mús
    public Transform PlayerCam;
    public float speedX = 2.0f;
    public float speedY = 2.0f;


    private float yaw = 0.0f;
    private float pitch = 0.0f;


   /* void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PlayerCam = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }*/


    void Update()
    {
        yaw += speedX * Input.GetAxis("Mouse X");
        pitch -= speedY * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        Cursor.lockState = CursorLockMode.Locked;


    }



}
