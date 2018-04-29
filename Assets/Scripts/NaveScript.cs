﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaveScript : MonoBehaviour {

    private Rigidbody2D rb;
    private float speed = 10f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(GameController.instance.gameOver ==false)
        {
            float movX = Input.acceleration.x;
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.gameOver = true;
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        Debug.Log("Murio");

    }
}
