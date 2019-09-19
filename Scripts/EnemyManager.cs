using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    // [HideInInspector] // seleccionar para esconder en el inspector dicha variable
    public int enemigosDestruidos;

    private void Awake()
    {
        // Arranca por defecto en cero
        enemigosDestruidos = 0;       
    }
}
