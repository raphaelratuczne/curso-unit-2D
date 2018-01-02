using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePato : MonoBehaviour {

	public float vel = 2.5f;
	public int moedas = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector2 (vel * Time.deltaTime, 0));
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector2 (-vel * Time.deltaTime, 0));
		}
	}

	void OnTriggerEnter2D(Collider2D outro) {
		if ( outro.gameObject.CompareTag("moeda") ) {
			moedas++;
			Destroy ( outro.gameObject );
		}
	}
}
