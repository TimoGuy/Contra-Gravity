﻿using UnityEngine;
using System.Collections;

public class QuitButtonBehavior : MonoBehaviour
{
    // Messages
    void ActionHappened()
    {
        Application.Quit();
    }
}
