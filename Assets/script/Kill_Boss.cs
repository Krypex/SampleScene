using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Boss : MonoBehaviour {
    public string scenetoload = "Difficulty Scene"; // Laddar SampleScene(Namnet på sennen)
    private void Update()
    {   // Om variabeln KillBoss i scriptet Kill_Boss_scr är ilka med 8 så händer detta nedanför
        if (Kill_Boss_scr.KillBoss == 8)
        {
            Movment.Jumpspeed = 15f;
            Movment.movespeed = 6f;
            SceneManager.LoadScene(scenetoload);  // Om taggen Player nuddar så laddar den SampleScene(Namnet på en sen)
            Money.score = 0;
        }
    }
    // Om ett objekt nuddar denna trigegr så händer detta nedanför
    private void OnTriggerEnter2D(Collider2D collision)
    {   // Om objektet har taggen Player så händer detta nedanför
        if (collision.tag == "Player")
        {
          
            Kill_Boss_scr.KillBoss = +1; // PLussar till 1 på variabeln Killboss i scriptet KIll_Boss_scr
          
        }
    }
}
