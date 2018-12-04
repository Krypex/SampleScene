using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour {

    private TextMeshProUGUI text;

	// Use this for initialization
	void Start () {

        text = GetComponent<TextMeshProUGUI>(); // Bestämmer vilken component/objekt variabeln påverkar
    }
	
	// Update is called once per frame
	void Update () {
        text.text = string.Format("Score: {0:000}", Money.score); // Visar hur mycket poäng du får!!
	}
}
