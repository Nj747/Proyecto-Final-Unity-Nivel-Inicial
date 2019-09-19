using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

    public Image barra;

    private Vida vida;
    private GameObject jugador;

    // Use this for initialization
    private void Awake()
    {
        jugador = GameObject.Find("Personaje");
        ExisteObjeto(jugador);

        vida = jugador.GetComponent<Vida>();
        ExisteComponente(vida);

    }
    
	// Update is called once per frame
	void Update () {
        //barra.fillAmount = vida.cantidad / 100;
        barra.fillAmount = vida.cantidad/100f;
	}

    private void ExisteObjeto(GameObject obj)
    {
        if (obj == null)
        {
            Debug.LogError("No existe el objeto");
        }
    }

    private void ExisteComponente(Component componente)
    {
        if (componente == null)
        {
            Debug.LogError("No existe el componente");
        }
    }
}
