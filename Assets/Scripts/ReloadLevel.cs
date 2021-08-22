using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour {

	public AudioSource click;

	// Use this for initialization
	public void ReiniciarNivel()
	{
		click.Play();
		SceneManager.LoadScene("TestNivel1");
            Debug.Log("Lose!");
	}

	public void ReiniciarJuego()
	{
		click.Play();
		SceneManager.LoadScene("Menu");
            Debug.Log("Win!");
	}
}
