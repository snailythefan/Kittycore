using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public string enemyName;
	public float healthPoints;
	public float speed;
	public float knockbackForceX;
	public float knockbackForceY;
	public float damageToGive;

	public GameObject efectoMuerte;

	public void GetDamage(float damage){
		healthPoints -= damage;
		if (healthPoints <= 0) {
			Muerte ();
		}
	}

	private void Muerte(){
		Instantiate (efectoMuerte, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
}
