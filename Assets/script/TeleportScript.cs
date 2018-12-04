using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public int amount = 101;


    private void OnTriggerEnter2D(Collider2D collision) // Bestämmer vilken component/objekt variabeln påverkar
    {
        
        if (collision.tag == "Player")
        {
            collision.transform.position = new Vector2(66.7587f, -21.38975f);
            Money.score += amount;
            Debug.Log("Teleport enter");  // Om taggen player nuddar detta objekt som scriptet sitter på så hamnar spelaren i en viss position och får den mängeden score = 101 poång

        }

    }

}



