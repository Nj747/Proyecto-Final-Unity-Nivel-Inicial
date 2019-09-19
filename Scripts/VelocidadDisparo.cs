using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadDisparo : MonoBehaviour {

    private float bonus;

    public ParticleSystem particulas; // doy la referencia al VFX 

    public AudioSource sndPowerUp; // doy referencia al SFX

    void Start()
    {
        bonus = -0.2f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.layer == 9)
        {
            // cambia el cada cuanto se instancian los disparos
            Disparador disp = other.gameObject.GetComponent<Disparador>();
            disp.repeatRate = disp.repeatRate + bonus;
             
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
