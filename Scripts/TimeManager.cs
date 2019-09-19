using UnityEngine;

public class TimeManager : MonoBehaviour {

    private float tiempoTranscurrido;

    private void Awake()
    {
        tiempoTranscurrido = 0;
    }
   
    void Update () {
        tiempoTranscurrido += Time.deltaTime;
	}

    // Devuelve el tiempo transcurrido desde el Awake()
    public float ObtenerTiempoTranscurrido()
    {
        return tiempoTranscurrido;
    }

}
