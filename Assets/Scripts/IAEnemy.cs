using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour {

	[SerializeField]
	Transform player;

	[SerializeField]
	float rangoAgro;

	public float velocidadMov;
	Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float distJugador = Vector2.Distance (transform.position, player.position);

		if (distJugador < rangoAgro) {
			PerseguirJugador ();
		} else {
			NoPerseguir ();
		}
	}

	void PerseguirJugador() {
		
		if (transform.position.x < player.position.x)
		{
			rb2d.velocity = new Vector2 (velocidadMov, 0f);
		}
		else if (transform.position.x > player.position.x)
		{
			rb2d.velocity = new Vector2 (-velocidadMov, 0f);
		}
	}

	void NoPerseguir() {
		rb2d.velocity = Vector2.zero;
	}
}