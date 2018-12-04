using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Changer : MonoBehaviour {
    public Color newcolor;
    public SpriteRenderer rend;

	// Update is called once per frame
	void Update () {

        timechecker_Jump();
        timechecker();
        White();
    }
    void timechecker_Jump()
    {
        if (Jumpspeed.timechecker_Jump == true && ExtraSpeed.timerchecker == false)
        {
            Debug.Log("test1");
            newcolor = rend.color = Color.yellow;

           
        }
        
    }
    void timechecker()
    {
        if (ExtraSpeed.timerchecker == true && Jumpspeed.timechecker_Jump == false)
        {
            Debug.Log("test3");
            newcolor = rend.color = Color.green;

           
        }
        
    }
    void White()
    {
        if(ExtraSpeed.timerchecker == false && Jumpspeed.timechecker_Jump == false)
        {
            newcolor = rend.color = Color.white;
        }
    }
    
}
