using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour {

	private float vel = 2.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		/*if ( Input.GetKey(KeyCode.RightArrow) ) {
			transform.Translate ( new Vector3(vel * Time.deltaTime, 0, 0) );
		}
		if ( Input.GetKey(KeyCode.LeftArrow) ) {
			transform.Translate ( new Vector3(-vel * Time.deltaTime, 0, 0) );
		}*/

		float H = Input.GetAxis ("Horizontal");
		float V = Input.GetAxis ("Vertical");
		transform.Translate (new Vector3 (H * Time.deltaTime, V * Time.deltaTime, 0));

	}
}
