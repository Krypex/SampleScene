using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_player : MonoBehaviour {
    

    // Use this for initialization
    public string scenetoload = "Boos Battle"; // Laddar SampleScene(Namnet på sennen)
    public int MinimumScoreNeeded = 0;
    
    // OM ett objekt nuddar denna trigger så händer detta nedanför
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // OM objektet har taggen player så händer detta nedanför
        if (collision.tag == "Player")
        {
            Movment.Jumpspeed = 15f;
            Movment.movespeed = 6f;
            SceneManager.LoadScene(scenetoload);  // Om taggen Player nuddar så laddar den SampleScene(Namnet på en sen)
            Money.score = 0;
            Kill_Boss_scr.KillBoss = 0;


        }

    }

}
