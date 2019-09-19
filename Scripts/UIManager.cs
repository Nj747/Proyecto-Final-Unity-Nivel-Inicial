using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Image imageTutorial;

    private void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 0)
        {
            imageTutorial.gameObject.SetActive(false);
        }
        
    }

    public void Jugar()
    {
        Invoke("CargarNivel",1f);
    }

    void CargarNivel()
    {
        SceneManager.LoadScene("Nivel 1");
    }
	
    public void Salir()
    {
        Application.Quit();
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu Principal");
    }

    public void Tutorial()
    {
        imageTutorial.gameObject.SetActive(true);
    }

    public void Volver()
    {
        imageTutorial.gameObject.SetActive(false);
    }
}
