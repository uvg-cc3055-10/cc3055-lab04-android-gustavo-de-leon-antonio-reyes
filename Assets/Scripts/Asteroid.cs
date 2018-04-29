using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gustavo De Leon 17085
//Antonio Reyes 17273
public class Asteroid : MonoBehaviour {

    
    private float speed = 10f;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -5.3)
        {
            Destroy(gameObject);
        }
    }

}

