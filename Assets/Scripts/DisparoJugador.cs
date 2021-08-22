using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour {

	public Transform firePoint;
	public GameObject bala;

	private void Update(){
		if(Input.GetButtonDown("Fire1")){

			Instantiate (bala, firePoint.position, firePoint.rotation);
		
		}
			
	}
		
}
