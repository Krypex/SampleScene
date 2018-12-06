using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public int amount = 101;

    // Om ett objekt nuddar denna trigger så händer det som står nedan för
    private void OnTriggerEnter2D(Collider2D collision) // Bestämmer vilken component/objekt variabeln påverkar
    {
        //Om ett objekt som har taggen Player så händer detta nedanför 
        if (collision.tag == "Player")
        {   
            // Ändrar Charcterens/transform positionen 
            collision.transform.position = new Vector2(66.7587f, -21.38975f);
            
            // Dett objektet får poängen som variabeln amount står för
            Money.score += amount;
           

        }

    }

}



