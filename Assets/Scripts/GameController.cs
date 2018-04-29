using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Gustavo De Leon 17085
//Antonio Reyes 17273
public class GameController : MonoBehaviour {

    public bool gameOver = false; //Variable que define el estado de vida del jugador   
    public static GameController instance; //Variable del gamecontroller
    public Text tiempoText;//Texto donde va el score
    public float tiempo = 0.0f;//Inicializacion del score
    // Use this for initialization
    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
        tiempo += Time.deltaTime;//Control del tiempo
        tiempoText.text = "Score: " + tiempo.ToString("f0") + " ";//Asigan el tiempo a un texto
                                                                  
        PlayerPrefs.SetFloat("highScore", tiempo);


    }
}
