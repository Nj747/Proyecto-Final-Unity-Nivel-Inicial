using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour {

    public GameObject prefab;

    public AudioSource sndDisparoEnemigo;

    // agregado para que sea aleatorio el tiempo de repeticion en cada objeto
    private float repeticionAleatoria;
    private float inicioAleatorio;

    private void Awake()
    {
        inicioAleatorio = Random.Range(0, 1.1f);
        repeticionAleatoria = Random.Range(0.6f, 1.5f);
        InvokeRepeating("Disparar", inicioAleatorio, repeticionAleatoria);
    }

    void Disparar()
    {
        sndDisparoEnemigo.Play();
        Vector3 vec = new Vector3(transform.position.x, transform.position.y, transform.position.z -2f);
        Instantiate(prefab,vec, transform.rotation);
    }
}
