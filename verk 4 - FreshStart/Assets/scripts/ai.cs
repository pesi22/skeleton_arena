using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour {
    public Transform player;
    Animator anim_bad;
    public int hitcount;

    // Use this for initialization
    void Start () {
      anim_bad = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
         Vector3 direction = player.position - transform.position;
        float angle = Vector3.Angle(direction, transform.forward);

        direction.y = 0;

        transform.rotation = Quaternion.Slerp(transform.rotation,
                                    Quaternion.LookRotation(direction), 0.1f);

        transform.Translate(0,0,0.05f);

       
       
    }



    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            anim_bad.SetTrigger("bad_attack");

            if (anim_bad.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                Destroy(collision.gameObject);
            }
        }
    }

}
