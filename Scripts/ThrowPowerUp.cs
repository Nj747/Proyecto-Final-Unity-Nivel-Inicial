using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPowerUp : MonoBehaviour {

    public GameObject prefabPowerUp;

    float azar;
    float posibilidadArrojar;

    private void Awake()
    {
        posibilidadArrojar = 4f;
        azar = Random.Range(1f, 10f);
    }

    // si murio el enemigo entonces existe la posibilidad de arrojar el PowerUp
    public void Mori()
    {
        if (azar <= posibilidadArrojar)
        {
            Instantiate(prefabPowerUp, transform.position, transform.rotation);
        }
    }
}
