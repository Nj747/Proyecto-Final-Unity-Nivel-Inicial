using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour {

    public float cantidad;
    public ParticleSystem particulas;

    private void Awake()
    {
        // Si no es el jugador, necesariamente es el enemigo
        if (gameObject.tag == "Player") { cantidad = 100; }
    }

    void Update ()
    {
	    if (cantidad <= 0 && gameObject.tag == "Enemigo")
        {
            SendMessage("Mori");
            EjecutarExplosion();
            Destroy(gameObject);
        }
        else if (cantidad<=0 && gameObject.tag =="Player")
        {
            EjecutarExplosion();
            Destroy(gameObject);
        }
	}

    void EjecutarExplosion()
    {
        Instantiate(particulas,transform.position,transform.rotation);
    }
}
