using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    // Use this for initialization
    public string scenetoload = "Difficulty Scene"; // Laddar SampleScene(Namnet på sennen)
    public int MinimumScoreNeeded = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger enter"); // Skriv trigger enter i kontroll panelen(Debug.Log)
        if(collision.tag == "Player")  
        {
            Jumpspeed.timechecker_Jump = false;
            ExtraSpeed.timerchecker = false;
            SceneManager.LoadScene(scenetoload);  // Om taggen Player nuddar så laddar den SampleScene(Namnet på en sen)
            Money.score = 0;
            
        }
    }
    
}
