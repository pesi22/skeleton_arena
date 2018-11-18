using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    private Vector3 velocity = Vector3.zero;
    private Rigidbody rb;
    private AudioSource sorceClip;
    private AudioClip swordhit;
    Animator anim;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        sorceClip.clip = swordhit;
	}

    public void Move (Vector3 _velocity)
    {
        velocity = _velocity;
    }
	
	// Update is called once per frame
	void Update () {
        ApplyStuff();
        walking();
        attack();
	}

    void walking()
    {
        if (velocity == Vector3.zero)
        {
            anim.SetBool("is_walking", false);
        }
        else
        {
            anim.SetBool("is_walking", true);
        }
    }

    void attack()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            anim.SetTrigger("Attack");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name== "spawnReddy(Clone)")
        {
            // Destroy(collision.gameObject);
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("WK_heavy_infantry_08_attack_B"))
            {
                Destroy(collision.gameObject);
            }
        }
        /* if (anim.GetCurrentAnimatorStateInfo(0).IsName("WK_heavy_infantry_08_attack_B"))
         {
             Destroy(gameObject);
         }*/
    }

    void ApplyStuff()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);  
        }
    }
}
