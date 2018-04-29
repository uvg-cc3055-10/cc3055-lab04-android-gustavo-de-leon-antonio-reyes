using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Iniciar : MonoBehaviour {

    public void startGame()
    {
        SceneManager.LoadScene("Principal", LoadSceneMode.Single);
    }
}
