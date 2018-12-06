using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStage2 : MonoBehaviour {

   
    public string scenetoload = "Stage2";
    public int MinimumScoreNeeded = 101;

    //Om något kolliderar med denna trigger så händer det nedan för
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om ett ebjekt med taggen nuddar detta objekt som scriptet ligger på
        // Så laddar den scenetolaod vilket betyder i detta fall sennen Stage2
        //Med 0 poäng
        if (collision.tag == "Player" && Money.score >= MinimumScoreNeeded) 
        {
            SceneManager.LoadScene(scenetoload);
            Money.score = 0;                           
        }
    }

}
