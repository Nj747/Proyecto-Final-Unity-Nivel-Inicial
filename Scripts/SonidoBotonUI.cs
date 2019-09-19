using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotonUI : MonoBehaviour {

    public AudioSource sndSFX;
    public AudioSource jugarSFX;

    public void ReproducirSFX()
    {
        sndSFX.Play();
    }
	
    public void Jugar()
    {
        jugarSFX.Play();
    }
}
