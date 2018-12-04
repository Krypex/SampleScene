using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundchecker : MonoBehaviour {
    public int isgrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isgrounded ++;  // Kollar om du är på marken
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isgrounded --;  // Kollar om du inte är på marken
    }
}
