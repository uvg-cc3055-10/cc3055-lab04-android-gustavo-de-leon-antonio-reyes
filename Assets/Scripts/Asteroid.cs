﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    
    private float scrollingSpeed = 5f;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * scrollingSpeed * Time.deltaTime);
        if (transform.position.y < -5.3)
        {
            Destroy(gameObject);
        }
    }

}

