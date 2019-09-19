using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorTemporizado : MonoBehaviour {

    public float tiempoAutoDest; // tiempo que tarda en autodestruirse el objeto

	private void Awake()
    {
        Invoke("Autodestruccion", tiempoAutoDest);
    }
    
    private void Autodestruccion()
    {
        Destroy(gameObject);
    }
}
