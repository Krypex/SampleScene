using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {
    public static bool Isdead; // static bey´´tyder att jag kan koppla denna variabel till andra script

    private void Start()
    {
       
    }
    // Use this for initialization
    public string scenetoload = "Difficulty Scene"; // Laddar SampleScene(Namnet på sennen)
    public int MinimumScoreNeeded = 0;
    
    // Om ett objekt nuddar denna trigger så händer detta nedan
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // OM ett objekt som har taggen Player nuddar ddetta objekt så kommer detta nedan hända
        if(collision.tag == "Player")  
        {
            Movment.Jumpspeed = 15f; // Variabeln Jumpspeed i scriptet movment ändras till 15
            Movment.movespeed = 6f; // Vatiabeln movespeed i scriptet movment ändras till 6
            SceneManager.LoadScene(scenetoload);  // Om taggen Player nuddar så laddar den SampleScene(Namnet på en sen)
            Money.score = 0;
            
        }

    }
    
}
