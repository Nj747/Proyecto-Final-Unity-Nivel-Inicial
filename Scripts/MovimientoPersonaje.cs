using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {

    public float velocidadMovimiento;
    public float velocidadRotacion;
	
	void Update () {

        float vertical = CrossPlatformInputManager.GetAxis("Vertical");
        float horz = CrossPlatformInputManager.GetAxis("Horizontal");

        transform.Translate(0, 0, velocidadMovimiento * Time.deltaTime * vertical);
        transform.Translate(velocidadMovimiento * Time.deltaTime *horz, 0, 0);
    }
}
