using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour {

    public bool explotar;

    public ParticleSystem particulas;

    private void Awake()
    {
        Invoke("Explosion", 0.5f);
    }

    void Explosion()
    {
        explotar = true;
    }

    private void OnTriggerStay(Collider c)
    {      
        if (explotar)
        {
            Instantiate(particulas, transform.position, transform.rotation);
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
    }

    void Update () {
        if (Input.GetButtonDown("Explotar"))
        {
            Destroy(gameObject);
        }
	}
}
