using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraSpeed : MonoBehaviour {
    public float timer;
    public static bool timerchecker; // static betyder att jag kan koppla denna variabel i andra script
    public float variabel;

 
    void Start () {
        // Att denna variabel är false/AV
        timerchecker = false;

    }
	
	
	void Update () {
        // Om denna variabel är lika med true/på så hämder detta nedanför
        if (timerchecker == true)
        {   
            // Variabeln timer är i realtid betyder att den är oberoende på fpsen i spelet
            timer += Time.deltaTime; // Timer ökar varenda sekund i real tid
            
        }
        // Om variabeln timer är större än 10 och variabeln timechecker = true/på så händer detta nedanför
        if (timer > 10 && timerchecker == true)
        {   // Variabeln movespeed i scriptet Movment = 6
            Movment.movespeed = 6;
            // Variabeln timechecker = fasle/av
            timerchecker = false;
        }
    }
    // Om ett objekt nuddar denna trigger så händer detta nedanför
    private void OnTriggerEnter2D(Collider2D collision)
    {   // Om objektet har taggen Player så händer detta nedan för
        if (collision.tag == "Player")
        {   // Variabeln timechecker = true/på
            timerchecker = true;
            // Om timer är större eller lika med 1 eller om timer är mindre eller lika med 10
            // så händer detta nedan för
            if (timer >= 1f || timer <= 10f)
            {
                // Variabeln movespeed i scriptet Movment +9
                Movment.movespeed += 9;

            }
        }

    }
}
