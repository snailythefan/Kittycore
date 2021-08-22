using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvanceIntro : MonoBehaviour {

	public GameObject pantalla1;
	public GameObject pantalla2;

	public AudioSource click;

	public void Avance()
	{
		click.Play();
		pantalla1.SetActive(false);
		pantalla2.SetActive(true);
	}



}
