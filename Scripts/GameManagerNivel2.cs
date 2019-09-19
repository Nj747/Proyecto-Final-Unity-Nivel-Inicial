using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerNivel2 : MonoBehaviour {

    [Header("Tiempo necesario para ganar")]
    [Tooltip("Representa un número de tipo float")]
    public float tiempoGanar;

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

    // Update is called once per frame
    void Update () {
        PasarDeNivel();

        if (vida.cantidad <= 0)
        {
            perder.gameObject.SetActive(true);
            Invoke("Perder", 2.0f);
        }
    }

    private void PasarDeNivel()
    {
        float deltaTime = timeManager.ObtenerTiempoTranscurrido();
        if (deltaTime >= tiempoGanar)
        {
            ganar.gameObject.SetActive(true);
            Invoke("CargarNivel", 2.0f);
        }
    }

    void CargarNivel()
    {
        SceneManager.LoadScene("Ganar");
    }

    void Perder()
    {
        SceneManager.LoadScene("Perder");
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
