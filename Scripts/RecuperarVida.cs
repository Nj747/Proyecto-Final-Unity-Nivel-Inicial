using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperarVida : MonoBehaviour {

    private float bonus;

    public ParticleSystem particulas; // doy la referencia al VFX 

    public AudioSource sndPowerUp; // doy referencia al SFX

    void Start()
    {
        // recupera 10 de vida
        bonus = 10;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.layer == 9)
        {
            Vida v = other.gameObject.GetComponent<Vida>();
            // solamente recupera vida si el personaje no está al máximo de su capacidad (en este caso 100)
            if (v.cantidad <= 90)
            {
                v.cantidad = v.cantidad + bonus;
            }

            // instancio sistema de particulas
            EjecutarParticulas();
            sndPowerUp.Play();

            // retraso la destruccion para que se termine de ejecutar el sonido
            Invoke("Destruccion", 1.0f);
        }

    }

    void EjecutarParticulas()
    {
        Instantiate(particulas, transform.position, transform.rotation);
    }

    void Destruccion()
    {
        Destroy(gameObject);
    }
}
