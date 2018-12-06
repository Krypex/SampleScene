using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMoment : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rbody;
    public bool Left = true;
   

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>(); // Bestämmer vilken component/objekt variabeln påverkar
    }
    private void FixedUpdate()
    {
        // Om variablen Left = true/på så händer detta nedan
        if (Left == true)
        {   //Denna kåd utger Fiendens hastighet!!
            rbody.velocity = (-(Vector2)transform.right * speed); // Hastigheten för Fienden !!
            
            //Denna kåd bestämmer vilken scale figuren är 
            transform.localScale = new Vector3(1, 1, 1); // Skalnignen av Fienden gör så att den går åt ett annat håll (Höger i spelet)
        }

        else
        {   //Denna kåd utger Fiendens hastighet!!
            rbody.velocity = ((Vector2)transform.right * speed); // Hastigheten för Fienden !!
            
            //Denna kåd bestämmer vilken scale figuren är 
            transform.localScale = new Vector3(-1, 1, 1);  // Skalnignen av Fienden gör så att den går åt ett annat håll (Vänster i spelet)

        }

      
    }
   // O´m detta objekt som har scriptet på nuddar en trigger så händer detta nedan
    private void OnTriggerEnter2D(Collider2D collision)
    {   // om objektet som är triggern har taggen Invisiblewall så händer detta nedan
        if (collision.tag == "InvisibleWall")
        {
            Left = !Left;  // Om Fienden går emot ett objekt med taggen Invisiablewall så vänder den riktning

        }
      
    }
}





















// transform.right = används i 3D inte 2D
// (Vector2)transfrom blir VEctor2.right
// Casting = rbody.MovePosition(rbody.position + (-(Vector2)transform.right * Time.deltaTime));
//  private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Left = !Left;
    //}