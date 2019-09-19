using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHorizontal : MonoBehaviour {
    Vector3 movimiento;

    public float velocidad;
    float centroDeMovimiento;
    // setea la cantidad de pixeles permitidos hacia un lado 
    private float limiteMovimiento = 5;

    [Header("Sentido Inicial de movimiento")]
    [Tooltip("Se debe ingresar un número entero: 1 o -1")]
    public int sentido; // selecciona el sentido inicial de movimiento del objeto

    private void Awake()
    {
        // comienza movimiento hacia la derecha
        movimiento.x = 1f; 
        movimiento.y = 0f;
        movimiento.z = 0f;
        centroDeMovimiento = transform.position.x;
    }

    void Update()
    {
        ActualizarMovimiento();
    }

    private void ActualizarMovimiento()
    {
        gameObject.transform.Translate(sentido * velocidad * movimiento * Time.deltaTime);

        float diferenciaTiempo = Time.time - Time.deltaTime;
        float diferenciaPosicion = transform.position.x - centroDeMovimiento;

        if (diferenciaTiempo >= 1)
        {
            velocidad += 0.01f;
            if (diferenciaPosicion >= limiteMovimiento)
            {
                sentido = -1;
            }
            else if (diferenciaPosicion <= -limiteMovimiento)
            {
                sentido = 1;
            }

            diferenciaTiempo = 0f;
        }
    }
}
