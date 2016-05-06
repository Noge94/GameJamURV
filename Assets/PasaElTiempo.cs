using UnityEngine;
using UnityEngine.UI;		//fa falta aixo per interactuar amb la UI
using System.Collections;

public class PasaElTiempo : MonoBehaviour
{
	private Text TiempoQueda;
	public int currentTiempo;
	public int startingTiempo = 60;
	public int TiempoPerdidoPorSegundo = 1;

	// Use this for initialization
	void Awake ()
	{
		currentTiempo = startingTiempo;
		TiempoQueda = GetComponent <Text> ();
		InvokeRepeating ("PasarElTiempo", 0f, 1f);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void PasarElTiempo() {
		//TODO Hacer pase el día
		currentTiempo -= TiempoPerdidoPorSegundo;

		if (currentTiempo > 10) {
			TiempoQueda.text = "00:" + currentTiempo;
		} else {
			TiempoQueda.text = "00:0" + currentTiempo;
		}

		if (currentTiempo == 0) {
			AcabaElDia();
		}
	}

	public void AcabaElDia(){
		currentTiempo = startingTiempo;
	}
}

