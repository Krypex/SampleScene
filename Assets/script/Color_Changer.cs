using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Changer : MonoBehaviour {
    public Color newcolor;
    public SpriteRenderer rend;

	// Update is called once per frame
	void Update () {

        timechecker_Jump(); // Kollar de olika voids i ordning
        timechecker();
        White();

    }
    void timechecker_Jump()
    {   // Om variabeln timechecker_Jump i scriptet Jumpspeed är lika med true/på 
        //Variabeln timechecker i scriptet Extraspeed är lika med flase/AV 
        // så hädner detta nedanför
        if (Jumpspeed.timechecker_Jump == true && ExtraSpeed.timerchecker == false)
        {
         
            newcolor = rend.color = Color.yellow; // Ändra färg på spriten

           
        }
        
    }
    void timechecker()
    {   // Om variabeln timechecker i scriptet Extraspeed är lika med true/på
        // och variabeln timechecker_Jump är lika med false/AV
        // så hädner detta nedanför
        if (ExtraSpeed.timerchecker == true && Jumpspeed.timechecker_Jump == false)
        {
           
            newcolor = rend.color = Color.green; // Ändra färg på spriten

        }
        
    }
    void White()
    {   // Om variabeln timechecker i scriptet Extraspeed är lika med false/av
        // och variabeln timechecker_Jump är lika med false/av
        // Så händer detta nedanför
        if(ExtraSpeed.timerchecker == false && Jumpspeed.timechecker_Jump == false)
        {
            newcolor = rend.color = Color.white; // Ändra färg på spriten
        }
    }
   
}
