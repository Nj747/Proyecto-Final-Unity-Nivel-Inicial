using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Disparador : MonoBehaviour {

    public GameObject prefab;
    public string nombreAccion;

    public AudioSource sndDisparo;

    // Agregué dicha variable para modificarla en Unity y jugar con los cambios allí
    public float repeatRate;

	void Update () {
		if (CrossPlatformInputManager.GetButtonDown(nombreAccion))
        {
            InvokeRepeating("Disparar", 0, repeatRate);
        }

        if (CrossPlatformInputManager.GetButtonUp(nombreAccion))
        {
            CancelInvoke("Disparar");
        } 
	}

    void Disparar()
    {
        sndDisparo.Play();
        Vector3 vec = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3f);
        Instantiate(prefab, vec, transform.rotation);

    }
}
