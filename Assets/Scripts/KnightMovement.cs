using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour {

    Animator anim;
    int jumpHash = Animator.StringToHash("Jump");

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", move);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger(jumpHash);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("Sprint", true);
        } else
        {
            anim.SetBool("Sprint", false);
        }


	}
}
