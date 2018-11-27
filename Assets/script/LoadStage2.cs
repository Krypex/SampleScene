using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStage2 : MonoBehaviour {

    // Use this for initialization
    public string scenetoload = "Stage2";
    public int MinimumScoreNeeded = 101;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger enter");
        if (collision.tag == "Player" && Money.score >= MinimumScoreNeeded)
        {
            SceneManager.LoadScene(scenetoload);
            Money.score = 0;
        }
    }

}
