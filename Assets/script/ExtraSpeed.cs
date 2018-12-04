using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraSpeed : MonoBehaviour {
    public float timer;
    public static bool timerchecker;
    public float variabel;

    // Use this for initialization
    void Start () {

        timerchecker = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (timerchecker == true)
        {
            timer += Time.deltaTime; // Timer ökar varenda sekund i real tid
            Debug.Log(string.Format("Timer: {0}", timer));
        }
        if (timer > 10 && timerchecker == true)
        {
            timerchecker = false;
           
            
            
            Movment.movespeed -= 9;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            timerchecker = true;

            if (timer >= 1f || timer <= 10f)
            {
                Movment.movespeed += 9;
               
               

            }
        }

    }
}
