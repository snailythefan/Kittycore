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

	public GameObject Life1;
	public GameObject Life2;
	public GameObject Life3;

	public AudioSource hurtNoise;

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
		if(collision.CompareTag("Enemy") && !isInmune)
		{
			health -= collision.GetComponent<Enemy> ().damageToGive;
			StartCoroutine (Inmunity ());

			if (health == 2)
			{
				Life3.SetActive(false);
				hurtNoise.Play();
			}
			else if (health == 1)
			{
				Life2.SetActive(false);
				hurtNoise.Play();

			}

			else if (health == 0)
			{

				//aparecer pantalla de game over
				Life1.SetActive(false);
				hurtNoise.Play();
				pantallaLose.SetActive(true);
				Destroy(mitti);
				Destroy(Bgmusic);
				Debug.Log("Lose");
			}
		}

	}

	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.CompareTag ("Enemy") && !isInmune) {
			health -= collision.gameObject.GetComponent<Enemy> ().damageToGive;
		}
	}

	IEnumerator Inmunity(){
		isInmune = true;
		yield return new WaitForSeconds (inmunityTime);
		isInmune = false;
	}
}
