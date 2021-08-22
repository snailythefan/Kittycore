using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public float health;
	public float maxHealth;
	bool isInmune;
	public float inmunityTime;

	public GameObject pantallaLose;
	public GameObject mitti;
	public GameObject Bgmusic;

	void Start(){
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (health > maxHealth) {
			health = maxHealth;
		}
	}

	private void OnTriggerEnter2D(Collider2D collision){
		if(collision.CompareTag("Enemy") && !isInmune){
			health -= collision.GetComponent<Enemy> ().damageToGive;
			StartCoroutine (Inmunity ());
			if (health <= 0) {

				//aparecer pantalla de game over
				pantallaLose.SetActive(true);
				Destroy(mitti);
				Destroy(Bgmusic);
				Debug.Log("Lose");
			}
		}

	}

	IEnumerator Inmunity(){
		isInmune = true;
		yield return new WaitForSeconds (inmunityTime);
		isInmune = false;
	}
}
