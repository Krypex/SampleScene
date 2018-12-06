using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ANimationScript : MonoBehaviour
{
    public static Color color = Color.white; // Static betyder att jag kan koppla min variabel till andra script
    public static SpriteRenderer rend;


    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>(); // Hämtar koponenten SPriteRenderer
    }

    // Update is called once per frame
    void Update()
    {
        if (ExtraSpeed.timerchecker == true)
        {
            color = Color.yellow;
            rend.material.color = color;
        }

        if (Jumpspeed.timechecker_Jump == true)
        {
            color = Color.green;
            rend.material.color = color;

        }
    }
    
   
}
