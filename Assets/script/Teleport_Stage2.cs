using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Stage2 : MonoBehaviour {

    public int amount = 305;
    // Om ett Objekt nuddar denna trigger så händer detta nedanför
    private void OnTriggerEnter2D(Collider2D collision) // Bestämmer vilken component/objekt variabeln påverkar
    {
        // Om objektet har taggen player så kommer detta nedanför att hända
        if (collision.tag == "Player")
        {
            collision.transform.position = new Vector2(155.6f, 6.38f); // Ger min transform/Charctär nya positioner
            Money.score += amount;
            Debug.Log("Teleport enter");  // Om taggen player nuddar detta objekt som scriptet sitter på så hamnar spelaren i en viss position och får den mängeden score = 101 poång

        }

    }

}
