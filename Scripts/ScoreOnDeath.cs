using UnityEngine;

public class ScoreOnDeath : MonoBehaviour {

    float puntajeGanado;

    EnemyManager enemyManager;

    GameObject scoreManagerObject;
    ScoreManager scoreManager;

    private void Awake()
    {
        ManejadorErrores();
    }

    public void MorirEnNivel4(GameObject objeto)
    {
        if (objeto.name == "Edificio")
        {
            scoreManager.puntaje += 20;
        }
        else
        {
            scoreManager.puntaje += 10;
        }
    }

    private void ManejadorErrores()
    {
        GameObject manager = GameObject.Find("Enemy Manager");
        ExisteObjeto(manager);

        enemyManager = manager.GetComponent<EnemyManager>();
        ExisteComponente(enemyManager);

        scoreManagerObject = GameObject.Find("Score Manager");
        ExisteObjeto(scoreManagerObject);

        scoreManager = scoreManagerObject.GetComponent<ScoreManager>();
        ExisteComponente(scoreManager);
    }

    void ExisteObjeto(GameObject obj)
    {
        if (obj == null)
        {
            Debug.LogError("No existe el objeto ");
        }
    }

    void ExisteComponente(Component comp)
    {
        if (comp == null)
        {
            Debug.LogError("No existe el componente ");
        }
    }

}
