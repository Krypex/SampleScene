using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latter : MonoBehaviour {
    public static bool latter = false; // static gör så jag kan koppla min cariabel till andra script
    // om ett objekt nuddar denna trigger så händerdetta nedan
    private void OnTriggerEnter2D(Collider2D collision)
    {   // Om objektet har taggen player och Knappen Leftshift är intrykt så händer detta nedan
        if (collision.tag == "Player" && Input.GetKey(KeyCode.LeftShift))
        {
            latter = true;
            // om variabeln latter är true/på så händer detta neadnför
            if (latter == true)
            {
                Movment.Jumpspeed = 30f; // variabeln Jumpspeed i scriptet movment blir 30 plus
            }
        }
       
    }
}
