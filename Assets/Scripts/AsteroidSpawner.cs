﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gustavo De Leon 17085
//Antonio Reyes 17273
//AsteroidSpawner permite lanzar asteroides de manera aleatoria
public class AsteroidSpawner : MonoBehaviour {

    public GameObject asteroid;
    //intervalo de tiempo entre cada lanzamiento de asteroide
    public float spawnTime = 1f;
    public float elapsedTime = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.gameOver == false)
        {
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2f, 2f);
                if (asteroid != null)
                    Instantiate(asteroid, new Vector3(random, 4.43f, 0), Quaternion.identity);
                
                elapsedTime = 0;
            }
        }
    }
}
