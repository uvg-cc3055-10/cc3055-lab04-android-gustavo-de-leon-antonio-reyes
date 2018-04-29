using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

//Gustavo De Leon 17085
//Antonio Reyes 17273
//Menu del juego
public class Iniciar : MonoBehaviour {
    public Text highText;
    private GameController dataControl;
    private float score;

    public void startGame()
    {
        //Al precionar el boton "Play", se va a cargar la Scene "Principal" y va a iniciar el juego.
        SceneManager.LoadScene("Principal", LoadSceneMode.Single);
    }
    void Update()
    {

    }

    public void menu()
    {
        dataControl.tiempo = PlayerPrefs.GetFloat("highScore");
        highText.text = "HighScore: " + PlayerPrefs.GetFloat("highScore");//Asigan el timepo a un texto
        Debug.Log(PlayerPrefs.GetFloat("highScore"));
    }
}
