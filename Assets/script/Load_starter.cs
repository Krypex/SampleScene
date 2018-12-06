using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_starter : MonoBehaviour {

    private void Start()
    {

    }
    // Use this for initialization
    public string scenetoload = "Starter Game"; // Laddar SampleScene(Namnet på sennen)
    public int MinimumScoreNeeded = 0;
    // om ett objekt nuddar denna trigger så händer deta nedanför
    private void OnTriggerEnter2D(Collider2D collision)
    {   // OM objektet har taggen player så händer detta nedaför
        if (collision.tag == "Player")
        {
            Movment.Jumpspeed = 15f;
            Movment.movespeed = 6f;
            SceneManager.LoadScene(scenetoload);  // Om taggen Player nuddar så laddar den SampleScene(Namnet på en sen)
            Money.score = 0;

        }

    }

}
