using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gustavo De Leon 17085
//Antonio Reyes 17273
public class Asteroid : MonoBehaviour {

    //velocidad del asteroide
    private float speed = 10f;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        //en el caso de que el asteroide llegue a la posicion y = -5.3, este va a desaparecer
        if (transform.position.y < -5.3)
        {
            Destroy(gameObject);
        }
    }

}

