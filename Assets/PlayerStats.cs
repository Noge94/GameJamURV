using UnityEngine;
using UnityEngine.UI;		//fa falta aixo per interactuar amb la UI
using System.Collections;

public class PlayerStats : MonoBehaviour
{
	public int vidaPerdidaPorSegundo = 1;
	public int aguaPerdidaPorSegundo = 1;
	public int TiempoPerdidoPorSegundo = 1;
    public int startingHealth = 100;
	public int startingWater = 100;
	public int startingTiempo = 60;
	public int currentHealth;
	public int currentWater;
	public int currentTiempo;
	public Slider healthSlider;
	public Slider waterSlider;
	public Slider tiempoSlider;

    void Awake ()
    {
		currentHealth = startingHealth;
		currentWater = startingWater;
		currentTiempo = startingTiempo;

		InvokeRepeating ("PerderHidratacion", 1f, 1f);
		InvokeRepeating ("PasarElTiempo", 1f, 1f);
    }


    void Update ()
    {
        
    }

	public void PasarElTiempo() {
		//TODO Hacer pase el día
		currentTiempo -= TiempoPerdidoPorSegundo;
		tiempoSlider.value = currentTiempo;
		if (currentTiempo == 0) {
			AcabaElDia();
		}
	}

	public void PerderVida() {
		//TODO Hacer que el personaje pierda x vida
		currentHealth -= vidaPerdidaPorSegundo;
		healthSlider.value = currentHealth;
		if (currentHealth == 0) {
			Morir();
		}
	}

	public void PerderHidratacion() {
		//TODO Hacer que el personaje pierda x Hidratación
		currentWater -= aguaPerdidaPorSegundo;
		waterSlider.value = currentWater;
		if (currentWater == 0) {
			PerderVida();
		}
	}

	public void Morir() {
		//TODO Lanzar Game Over
	}

	public void AcabaElDia() {
		//TODO Restart Level
	}
}
