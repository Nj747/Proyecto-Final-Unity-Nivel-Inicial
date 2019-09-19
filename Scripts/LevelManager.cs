using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public Scene escena;
    public int index;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        escena = SceneManager.GetActiveScene();
        index = escena.buildIndex;
    }
}
