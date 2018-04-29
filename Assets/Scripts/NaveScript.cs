using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Gustavo De Leon 17085
//Antonio Reyes 17273
public class NaveScript : MonoBehaviour {

    private Rigidbody2D rb;
    private float speed = 10f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //mientras que siga viva la nave
        if(GameController.instance.gameOver ==false)
        {
            float movX = Input.acceleration.x;
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        }
        

    }

    //en el caso de una colision, es game over, por lo que se va a cargar a la Scene "Menu"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.gameOver = true;

        // Se va a la Scene "Menu"
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        Debug.Log("Murio");

    }
}
