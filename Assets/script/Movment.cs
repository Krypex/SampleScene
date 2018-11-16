using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour {
    public float movespeed = 6f;
    public float Jumpspeed = 15f;

    public Groundchecker groundcheck;

    private Rigidbody2D rbody;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();


	}
	
	// Update is called once per frame
	void Update () {
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, 
            rbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if(groundcheck.isgrounded == true)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, Jumpspeed);

            }
        }
        

	}
}
