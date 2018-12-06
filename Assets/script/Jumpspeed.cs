using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpspeed : MonoBehaviour
{
    public float timer;
    public static bool timechecker_Jump; // static betyder ett denna variabel sträcker sig över alla script som jag har
    public float variabel;               // Att jag kan koppla den i andra script

    void Start()
    {   // Gör denna variabeln till false/AV
        timechecker_Jump = false;
    }

    // Update is called once per frame
    void Update()
    {   // Om denna variabel är true/på så händer detta nedanför
        if (timechecker_Jump == true)
        {   // Denna varibeln (timer) uppdateras i real tid altså inte fter fpsen i spelet

            timer += Time.deltaTime; // Timer ökar varenda sekund i real tid
            Debug.Log(string.Format("Timer: {0}", timer));
        }
        // Om denna variabeln är true/PÅ så händer detta nedanstående 
        if (timer > 10 && timechecker_Jump == true)
        {
            // Att Variabeln Jumpspeed i scriptet Movment är lika med 15 (bass värdet)
            Movment.Jumpspeed = 15;
            // Att denna variabeln är false/AV
            timechecker_Jump = false;
           
        }
    }
    // Om ett objekt nuddar denna trigger så händer detta nedan
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        // Om objektet har taggen Player så händer detta nedanför
        if (collision.tag == "Player")
        {   
            // Att denna variabel är true/PÅ
            timechecker_Jump = true;

            // Om variabeln timer är mer eller lika med 1 eller mindre eller lika med 10 så
            //så händer detta nedanför
            if (timer >= 1f || timer <= 10f)
            {
                // Variabeln Jumpspeed i scriptet movment blir 7 mer
                Movment.Jumpspeed += 7;

            }
        }
       
    }
}
