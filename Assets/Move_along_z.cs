﻿using UnityEngine;
using System.Collections;
using System;

public class Move_along_z : MonoBehaviour 
{
    public Transform refPointGrid;
	public static float speed=0.03f;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        try
        {
            if (Mathf.Abs(transform.position.z) >= refPointGrid.position.z)
            {
                speed = -speed;
            }
            if (Time.timeScale == 1)
            {
                transform.Translate(0, 0, speed);
            }
        }
        catch (Exception e)
        {
            print(e.Message);
        }
	}
}
