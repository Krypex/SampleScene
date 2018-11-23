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
            Destroy(gameObject);
            Money.score += amount;
        }
    }
    private void Update()
    {
        transform.Rotate(0, spinspeed * Time.deltaTime, 0);

    }
}
