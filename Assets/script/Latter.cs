using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latter : MonoBehaviour {
    public static bool latter = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            latter = true;
            Movment.Jumpspeed = +10;
        }
    }
}
