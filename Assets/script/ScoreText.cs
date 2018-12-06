using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour {

    private TextMeshProUGUI text;

	void Start () {
        //Den hämter Commponenten texMeshProGUI
        text = GetComponent<TextMeshProUGUI>(); // Bestämmer vilken component/objekt variabeln påverkar
    }
	
	// Kollar varända frame vilken påong/score det är 
	void Update () {
        text.text = string.Format("Score: {0:000}", Money.score); // Visar hur mycket poäng du får!!
	}
}
