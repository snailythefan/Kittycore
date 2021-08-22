using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	public GameObject gameObject;

	public GameObject player;
	private Transform playerTrans;
	private Rigidbody2D bulletRb;

	[SerializeField] private float speed;
	[SerializeField] private float damage;

	void Awake(){
		bulletRb = GetComponent<Rigidbody2D> ();

		player = GameObject.FindGameObjectWithTag ("Player");
		playerTrans = player.transform;
	}

	void Start() {
		if (playerTrans.localScale.x > 0) {
			bulletRb.velocity = new Vector2 (speed, bulletRb.velocity.y);
		} else {
			bulletRb.velocity = new Vector2 (-speed, bulletRb.velocity.y);
	
		}
	}

	//private void Update() {
	//	transform.Translate (Vector2.right * speed * Time.deltaTime);
	//}

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("Enemy")) {
			other.GetComponent<Enemy> ().GetDamage (damage);
			Destroy (gameObject);
		}
	}
}
