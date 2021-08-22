using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour {

	public float DistancePlayer;
	public float RangeVision;
	public float RangeReverse;
	public float Speed;
	public float ReverseSpeed;

	public Transform Player;
	public Rigidbody2D Rb2d;

	private void Update(){
		DistancePlayer = Vector2.Distance (Player.position, Rb2d.position);
		if (DistancePlayer < RangeVision && DistancePlayer > RangeReverse) {
			Vector2 Objetivo = new Vector2 (Player.position.x, Player.position.y); 
			Vector2 NuevaPosicion = Vector2.MoveTowards (Rb2d.position, Objetivo, Speed * Time.deltaTime);
			Rb2d.MovePosition (NuevaPosicion);
		} else if (DistancePlayer < RangeReverse) {
			Vector2 Objetivo = new Vector2 (Player.position.x, Player.position.y); 
			Vector2 NuevaPosicion = Vector2.MoveTowards (Rb2d.position, Objetivo, ReverseSpeed * Time.deltaTime);
			Rb2d.MovePosition (NuevaPosicion);
		}
	}
}
