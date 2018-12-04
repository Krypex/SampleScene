using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour {

    public int amount = 100;
    private float spinspeed = 180;
    public static int score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);   // Om taggen Player nuddar ett object med det här scriptet på så får spelaren en viss summa pengaroch objektet förstörs!
            Money.score += amount;  // Texten Score är lika med summan det du får av objektet!
        }
    }
    private void Update()
    {
        transform.Rotate(0, spinspeed * Time.deltaTime, 0); // Gör så objektet snörrar

    }
}
