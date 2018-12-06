using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_SampleScene1 : MonoBehaviour {
    
    // Use this for initialization
    public string scenetoload = "SampleScene1"; // Laddar SampleScene(Namnet på sennen)
    public int MinimumScoreNeeded = 0;
    // Om ett objekt nuddar denna trigger så händer detta nedanför
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om objektet har taggen ´player så händer detta nedanför
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(scenetoload);  // Om taggen Player nuddar så laddar den SampleScene(Namnet på en sen)
            Money.score = 0;
        }
    }

}
