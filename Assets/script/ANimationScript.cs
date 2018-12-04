using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ANimationScript : MonoBehaviour
{
    public static Color color = Color.white;
    public static SpriteRenderer rend;


    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>();
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
