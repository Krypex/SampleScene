using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfLatter : MonoBehaviour {

    // Om ett objekt nuddar denna trigger så händer detta nedanför
    private void OnTriggerEnter2D(Collider2D collision)
    {   // Om objektet har taggen palyer och variabeln latter i scriptet Latter är true/på 
        // så hädner dett nedanför
        if(collision.tag == "Player" && Latter.latter == true)
        {
            Latter.latter = false;
            //om variabeln latter i scriptet är flase/ på sä händer detta nedanför
            if(Latter.latter == false)
            {
                Movment.Jumpspeed = 15f;
            }
        }
    }
}
