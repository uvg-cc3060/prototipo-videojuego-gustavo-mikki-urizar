using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

	public GameObject player;
	public float smooth;

	private Vector2 velocidad;



	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void FixedUpdate () {
		float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x+5, ref velocidad.x, smooth);
		float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y+2, ref velocidad.y, smooth);

		transform.position = new Vector3 (posX, posY, transform.position.z);
	}
}
