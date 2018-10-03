using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Animator animator;
    float vert;
	// Use this for initialization
	void Start () { 
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        vert = Input.GetAxis("Vertical");
        animator.SetFloat("walkFloat", vert);
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("jumping", true);
        }
        else
        {
            animator.SetBool("jumping", false);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //Debug.Log("w is pressed");
            animator.SetBool("runBool", true);
        }
        else
        {
            animator.SetBool("runBool", false);
        }
	}
}
