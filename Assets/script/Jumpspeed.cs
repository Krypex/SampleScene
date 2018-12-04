using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpspeed : MonoBehaviour
{
    public float timer;
    public static bool timechecker_Jump;
    public float variabel;

    // Use this for initialization
    void Start()
    {
        timechecker_Jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timechecker_Jump == true)
        {
            timer += Time.deltaTime; // Timer ökar varenda sekund i real tid
            Debug.Log(string.Format("Timer: {0}", timer));
        }
        if (timer > 10 && timechecker_Jump == true)
        {

            Movment.Jumpspeed = 15;
            timechecker_Jump = false;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            timechecker_Jump = true;

            if (timer >= 1f || timer <= 10f)
            {
                Movment.Jumpspeed += 7;

                
                
            }
        }
       
    }
}
