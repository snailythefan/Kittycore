using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	//public GameObject gameObject;

	public GameObject player;
	private Rigidbody2D bulletRb;

	private SpriteRenderer sprite;
	public float speed;
	public float damage;

	void Start(){
		bulletRb = GetComponent<Rigidbody2D> ();

		player = GameObject.FindGameObjectWithTag ("Player");
		sprite = player.GetComponent<SpriteRenderer> ();
	}

	void Update() {
		if (!sprite.flipX) {
			bulletRb.velocity = new Vector2 (speed, bulletRb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		} else {
			bulletRb.velocity = new Vector2 (-speed, bulletRb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
	}

	//private void Update() {
	//	transform.Translate (Vector2.right * speed * Time.deltaTime);
	//}

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("Enemy")) {
			other.GetComponent<Enemy> ().GetDamage (damage);
			//Destroy (gameObject);
		}
	}
}
