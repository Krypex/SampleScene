using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPower : MonoBehaviour {
    public int spinspeed = 180;
    
    // OM ett objekt nuddar denna trigger så händer detta nedanför
    private void OnTriggerEnter2D(Collider2D collision)
    {   // OM objektet har taggen player så händer detta nesdanför
        if (collision.tag == "Player")
        {
            Destroy(gameObject);   // Om taggen Player nuddar ett object med det här scriptet på så får spelaren en viss summa pengaroch objektet förstörs!
            Kill_Boss_scr.KillBoss += 1;
        }
    }
    private void Update()
    {
        transform.Rotate(0, spinspeed * Time.deltaTime, 0); // Gör så objektet snörrar

    }
}

