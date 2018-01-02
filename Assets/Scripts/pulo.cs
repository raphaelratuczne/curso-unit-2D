﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulo : MonoBehaviour {

	public float forca = 500f;
	public Rigidbody2D bola;
	public bool liberaPulo = false;
	public int duplo = 2;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( duplo > 0 ) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				bola.AddForce ( new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse );
				duplo--;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D outro) {
		if (outro.gameObject.CompareTag ("chao")) {
			duplo = 2;
			// liberaPulo = true;
		}
	}

	/*void OnCollisionExit2D(Collision2D outro) {
		if (outro.gameObject.CompareTag ("chao")) {
			liberaPulo = false;
		}
	}*/
}
