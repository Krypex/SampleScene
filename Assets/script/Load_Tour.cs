using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Tour : MonoBehaviour {

    public string scenetoload = "Tour"; // Laddar SampleScene(Namnet på sennen)
    public int MinimumScoreNeeded = 0;
    // Om ett objekt nuddar denna tirgger så hädner detta nedanför 
    private void OnTriggerEnter2D(Collider2D collision)
    {   // Om objektet har taggen player så haänder detta nedanför
        if (collision.tag == "Player")
        {
            Movment.Jumpspeed = 15f;
            Movment.movespeed = 6f;
            SceneManager.LoadScene(scenetoload);  // Om taggen Player nuddar så laddar den SampleScene(Namnet på en sen)
            Money.score = 0;

        }

    }

}
