using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfLatter : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && Latter.latter == true)
        {
            Movment.Jumpspeed = 15;
        }
    }
}
