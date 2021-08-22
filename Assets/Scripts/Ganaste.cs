using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganaste : MonoBehaviour {

	//public static bool IsInputEnabled = true;

	public GameObject pantallaWin;
	public GameObject JugaPlayer;

	public GameObject Heart;

	public AudioSource WinSong;
	public AudioSource bgMsuci;

	public float wait = 2f;

	private void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{

			//GameManager.IsInputEnabled = false;
			StartCoroutine(ShowPantalla());

		}
		else
		{
			Debug.Log("Contact!");
		}
	}

	IEnumerator ShowPantalla()
	{
		//show heart
		Heart.SetActive(true);
		WinSong.Play();
		Destroy(bgMsuci);


		//wait

		yield return new WaitForSeconds(wait);

		//show scene and explode
		pantallaWin.SetActive(true);
		Destroy(JugaPlayer);
		
		Debug.Log("Win");
	}
}
