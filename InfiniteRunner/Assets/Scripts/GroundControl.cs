﻿using UnityEngine;
using System.Collections;

public class GroundControl : MonoBehaviour
{
    float speed = 0.5f;
    public Renderer rend;


	// Use this for initialization
	void Start ()
    {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float offset = Time.time * speed;
        rend.material.mainTextureOffset = new Vector2(0, offset);
    }
}
