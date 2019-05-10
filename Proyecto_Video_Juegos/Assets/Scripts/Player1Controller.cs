﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;
	public CharacterController controller;
	public float gravityScale;

	private Vector3 moveDirection;

	// Use this for initialization
	void Start () {

		controller = GetComponent<CharacterController> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		moveDirection = new Vector3 (Input.GetAxis ("Horizontal") * moveSpeed, 0f, Input.GetAxis ("Vertical") * moveSpeed);

		if (Input.GetButtonDown ("Jump")) 
		{
			
			moveDirection.y = jumpForce;
		}

		moveDirection.y = moveDirection.y + (Physics.gravity.y * Time.deltaTime);
		controller.Move (moveDirection * Time.deltaTime);
	}
}
