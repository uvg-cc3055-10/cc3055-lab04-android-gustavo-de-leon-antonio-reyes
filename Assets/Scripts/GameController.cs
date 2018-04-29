using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public bool gameOver = false;
    public int score = 0;
    public static GameController instance;
    
    public Text tiempoText;
    public float tiempo = 0.0f;
    // Use this for initialization
    void Start()
    {
        instance = this;
        
        


    }

    // Update is called once per frame
    void Update()
    {
        
        tiempo += Time.deltaTime;
        tiempoText.text = "Score: " + tiempo.ToString("f0") + " ";


    }
}
