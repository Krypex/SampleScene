using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Boss_scr : MonoBehaviour {
    public static int KillBoss; // static betyder att min varibel kan kopplas till andra script

    // Use this for initialization
    private void Update()
    {   // om variabeln KIllboss är lika med 8 så händer detta nedanför
        if (KillBoss == 8)
        {
            Destroy(gameObject); // förstör objektet

        }
    }

}
