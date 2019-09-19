using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danador : MonoBehaviour {

    public float danio;

    private Vida vidaObjeto;

    public AudioSource sndCrash;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag != gameObject.tag) && (other.gameObject.layer == 9))
        {
            QuitarVida(other);
        }
        else if (other.gameObject.tag == "PowerUps" || other.gameObject.layer == 10)
        {
            // no panza nada, lo atraviesa
        }
        else
        {
            sndCrash.Play();
            Invoke("Destruccion", 0.1f);
        }
    }

    private void QuitarVida(Collider other)
    {
        vidaObjeto = other.gameObject.GetComponent<Vida>();
        vidaObjeto.cantidad = vidaObjeto.cantidad - danio;
    }

    void Destruccion()
    {
        Destroy(gameObject);
    }
}
