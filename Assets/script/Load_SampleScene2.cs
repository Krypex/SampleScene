using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_SampleScene2 : MonoBehaviour {

    // Use this for initialization
    public string scenetoload = "SampleScene2"; // Laddar SampleScene(Namnet på sennen)
    public int MinimumScoreNeeded = 0;
    // om ett objekt nuddar denna t´rigger så händer detta nedan för 
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // om objektet har taggen play8er så händer detta nedanför
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(scenetoload);  // Om taggen Player nuddar så laddar den SampleScene(Namnet på en sen)
            Money.score = 0;
        }
    }

}
