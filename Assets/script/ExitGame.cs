﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // OM ett objekt nuddar triggern så händer detta nedanför
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false; // Aavslutar spelet
    }
}
