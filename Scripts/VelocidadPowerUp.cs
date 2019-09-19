using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadPowerUp : MonoBehaviour {

    private float bonus;

    public ParticleSystem particulas; // doy la referencia al VFX 

    public AudioSource sndPowerUp; // doy referencia al SFX

	void Start () {
        bonus = 10;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.layer == 9)
        {
            MovimientoPersonaje m = other.gameObject.GetComponent<MovimientoPersonaje>();
            m.velocidadMovimiento = m.velocidadMovimiento + bonus;
            m.velocidadRotacion = m.velocidadRotacion + bonus;

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
