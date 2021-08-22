using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	public GameObject GameObject;

	[SerializeField] private float speed;
	[SerializeField] private float damage;

	private void Update() {
		transform.Translate (Vector2.right * speed * Time.deltaTime);
	}

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("Enemy")) {
			other.GetComponent<Enemy> ().GetDamage (damage);
			Instantiate (GameObject);
		}
	}
}
