using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour {
    public static float movespeed = 6f; // static betyder att jag kan koppla dessa variablre i andra script
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
        // Om knappen JUmp trycks ner så händer detta 
        if (Input.GetButtonDown("Jump"))
        {   // Om variabeln grounded är större än 0 så händer detta nedan
            if (groundcheck.isgrounded > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, Jumpspeed); // Kollar om man är på marken, om man inte är det så kan du inte hoppa(du kan bara hoppa en gång)

            }
        }
     
    }
}
