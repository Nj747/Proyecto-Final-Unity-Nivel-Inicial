using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transicion : MonoBehaviour {

    GameObject lvlManager;

    int indice;

    private void Awake()
    {
        lvlManager = GameObject.Find("Master Manager");
        indice = lvlManager.GetComponent<LevelManager>().index;
    }

    public void Reintentar()
    {
        SceneManager.LoadScene(indice);
    }

    public void SiguienteNivel()
    {
        lvlManager.GetComponent<LevelManager>().index = indice+1;
        SceneManager.LoadScene(indice + 1);
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}
