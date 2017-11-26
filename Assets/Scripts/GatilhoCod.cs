using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatilhoCod : MonoBehaviour {

	public bool liberaRot;
	public GameObject Ferradura;

	void Start () {
		liberaRot = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (liberaRot == true) {
			Ferradura.gameObject.transform.Rotate (new Vector3(0,0,25 * Time.deltaTime));
		}
	}

	void OnTriggerEnter2D(Collider2D outro) {
		if (outro.gameObject.CompareTag ("ave")) {
			liberaRot = true;
		}
	}
	void OnTriggerExit2D(Collider2D outro) {
		if (outro.gameObject.CompareTag ("ave")) {
			liberaRot = false;
		}
	}
}
