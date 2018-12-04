using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour {
    public static float movespeed = 6f;
    public static float Jumpspeed = 15f;
    
    public Groundchecker groundcheck;
    
    private Rigidbody2D rbody;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>(); // Bestämmer vilken component/objekt variabeln påverkar


    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, // Gör så att charactären till höger is spelet, altså spelarens höger spelar ej roll vilket håll spelet ligger 
            rbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (groundcheck.isgrounded > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, Jumpspeed); // Kollar om man är på marken, om man inte är det så kan du inte hoppa(du kan bara hoppa en gång)

            }
        }
     
    }
}
