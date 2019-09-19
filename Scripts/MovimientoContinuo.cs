using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoContinuo : MonoBehaviour {

    public float velocidadX;
    public float velocidadY;
    public float velocidadZ;

	// Use this for initialization
	void Start () {
        transform.Translate(0,0,0);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ * Time.deltaTime);
    }
}
