using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public int amount = 101;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            collision.transform.position = new Vector2(66.7587f, -21.38975f);
            Money.score += amount;
            Debug.Log("Teleport enter");

        }

    }

}



