﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour {

	[SerializeField] private float tiempoDeVida;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, tiempoDeVida);
	}
}
