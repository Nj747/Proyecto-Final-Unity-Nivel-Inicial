using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    private EnemyManager enemyManager;
    GameObject manager;

    GameObject scoreOnDeath;
    ScoreOnDeath scoreDeath;

    private void Awake()
    {
        ManejadorErrores();
    }

    public void Mori()
    {
        // actualiza la cantidad de enemigos en el EnemyManager
        enemyManager.enemigosDestruidos += 1;

        if (EstoyEnNivel4())
        {
            scoreDeath.MorirEnNivel4(gameObject);
        }
    }

    // Método que verifica la existencia de los objetos y componentes a encontrar
    private void ManejadorErrores()
    {
        manager = GameObject.Find("Enemy Manager");
        ExisteObjeto(manager);

        enemyManager = manager.GetComponent<EnemyManager>();
        ExisteComponente(enemyManager);

        if (EstoyEnNivel4())
        {
            scoreOnDeath = GameObject.Find("Score On Death");
            ExisteObjeto(scoreOnDeath);

            scoreDeath = scoreOnDeath.GetComponent<ScoreOnDeath>();
            ExisteComponente(scoreDeath);
        }
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

    private bool EstoyEnNivel4()
    {
        GameManagerNivel4 nivel4 = manager.GetComponent<GameManagerNivel4>();
        if (nivel4 != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
