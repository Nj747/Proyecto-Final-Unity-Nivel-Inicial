using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerNivel3 : MonoBehaviour {

    [Header("Condiciones para pasar de nivel")]
    [Tooltip("Tiempo necesario para ganar, variable de tipo float")]
    public float tiempoGanar;
    [Tooltip("Enemigos a eliminar, variable de tipo int")]
    public int enemigosEliminar;

    private EnemyManager enemyManager;
    private GameObject manager;

    GameObject timeObject;
    TimeManager timeManager;

    GameObject jugador;
    Vida vida;

    public Text ganar;
    public Text perder;

    private void Awake()
    {
        ganar.gameObject.SetActive(false);
        perder.gameObject.SetActive(false);
        ManejadorErrores();  
    }

    void Update()
    {
        PasarDeNivel();

        if (vida.cantidad <= 0)
        {
            perder.gameObject.SetActive(true);
            Invoke("Perder", 2f);
        }
    }

    private void PasarDeNivel()
    {
        float time = timeManager.ObtenerTiempoTranscurrido();
        // Si mato a los enemigos necesarios o cumplio el tiempo de supevivencia => pasa de nivel
        if (time >= tiempoGanar || enemyManager.enemigosDestruidos >= enemigosEliminar)
        {
            ganar.gameObject.SetActive(true);
            Invoke("CambioEscena", 2.0f);       
        }
    }

    void Perder()
    {
        SceneManager.LoadScene("Perder");
    }

    private void CambioEscena()
    {
        SceneManager.LoadScene("Ganar");
    }

    private void ManejadorErrores()
    {
        manager = GameObject.Find("Enemy Manager");
        ExisteObjeto(manager);

        enemyManager = manager.GetComponent<EnemyManager>();
        ExisteComponente(enemyManager);

        timeObject = GameObject.Find("Time Manager");
        ExisteObjeto(timeObject);

        timeManager = timeObject.GetComponent<TimeManager>();
        ExisteComponente(timeManager);

        jugador = GameObject.Find("Personaje");
        ExisteObjeto(jugador);

        vida = jugador.GetComponent<Vida>();
        ExisteComponente(vida);
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
