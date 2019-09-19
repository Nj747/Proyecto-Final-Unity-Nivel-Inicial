using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerNivel4 : MonoBehaviour {

    // [HideInInspector] // Descomentar esta línea para esconder del inspector de Unity
    [Header ("Condiciones para Ganar o Perder")]
    public float puntajeGanar;
    public float tiempoPerder;

    GameObject scoreManagerObject;
    ScoreManager scoreManager;

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
    }

    private void PasarDeNivel()
    {
        float time = timeManager.ObtenerTiempoTranscurrido();

        if (scoreManager.puntaje >= puntajeGanar)
        {
            SceneManager.LoadScene("Ganar Juego");
        }
        else if (time > tiempoPerder)
        {
            SceneManager.LoadScene("Perder");
        }
        else if (vida.cantidad <= 0)
        {
            SceneManager.LoadScene("Perder");
        }
    }

    private void ManejadorErrores()
    {
        timeManager = gameObject.GetComponent<TimeManager>();
        ExisteComponente(timeManager);

        scoreManagerObject = GameObject.Find("Score Manager");
        ExisteObjeto(scoreManagerObject);

        scoreManager = scoreManagerObject.GetComponent<ScoreManager>();
        ExisteComponente(scoreManager);

        jugador = GameObject.Find("Personaje");
        ExisteObjeto(jugador);

        vida = jugador.GetComponent<Vida>();
        ExisteComponente(vida);
    }

    void ExisteObjeto(GameObject obj)
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
