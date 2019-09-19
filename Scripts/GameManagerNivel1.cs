using UnityEngine;
using UnityEngine.SceneManagement; // para usar el Scene Manager porque el Application.LoadLevel esta obsoleto
using UnityEngine.UI;

public class GameManagerNivel1 : MonoBehaviour {

    [Header ("Cantidad de Enemigos a eliminar en el nivel")]
    public int enemigosEliminar;

    private EnemyManager enemyManager;
    private GameObject manager;

    private GameObject jugador;
    private Vida vida;

    public Text ganar;
    public Text perder;

    private void Awake()
    {
        ManejadorErrores();
        ganar.gameObject.SetActive(false);
        perder.gameObject.SetActive(false);
    }

    void Update () {
        PasarDeNivel();

        if (vida.cantidad <= 0)
        {
            perder.gameObject.SetActive(true);
            Invoke("Perder",2.0f);
        }

    }

    private void PasarDeNivel()
    {
        if (enemyManager.enemigosDestruidos >= enemigosEliminar)
        {
            ganar.gameObject.SetActive(true);
            Invoke("CargarNivel", 2f);
        }
    }

    void CargarNivel()
    {
        // Cambio a pantalla Ganar
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
