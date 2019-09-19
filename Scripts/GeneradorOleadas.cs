using UnityEngine;

public class GeneradorOleadas : MonoBehaviour {

    public GameObject prefabEnemigo;

    // Variable agregada para probar en el editor de Unity cada cuanto se instancian nuevos enemigos
    public float repeatRate;

    private void Awake()
    {
        InvokeRepeating("Crear", 0, repeatRate);
    }

    private void Crear()
    {
        Instantiate(prefabEnemigo, transform.position, transform.rotation);
    }
}
