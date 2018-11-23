using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    // Use this for initialization
    public string scenetoload = "SampleScene";
    public int MinimumScoreNeeded = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger enter");
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(scenetoload);
            Money.score = 0;
        }
    }
    
}
