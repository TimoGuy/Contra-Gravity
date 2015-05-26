﻿using UnityEngine;
using System.Collections;

public class AlphaControls : MonoBehaviour
{
    public float alpha;

	// Update
	void Update()
	{
        Color c = GetComponent<Renderer>().material.color;
        c.a = alpha;
        GetComponent<Renderer>().material.color = c;
        Debug.Log("alpha " + alpha);
	}
}