﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player2Controller : MonoBehaviour  {

	public float moveSpeed;
	public float jumpForce;
	//public Rigidbody theRB;
	private Rigidbody rb2d;
	public CharacterController controller;
	public float gravityScale;
	private Vector3 moveDirection;
	public Slider healthFill;
	public float currentHealth;
	public float maxHealth;
	public Slider oxigenFill;
	public Camera cam;
    public bool herramienta; 

	// Use this for initialization
	void Start () {

		controller = GetComponent<CharacterController> ();
		rb2d = GetComponent<Rigidbody>();
        herramienta = false;
		//theRB = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update () {

		moveDirection = new Vector3 (Input.GetAxis ("Horizontal2") * moveSpeed, 0f, 0f);
		//theRB.velocity = new Vector3(Input.GetAxis ("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis ("Vertical") * moveSpeed);

		if (Input.GetButtonDown ("Jump")) 
		{

			moveDirection.y = jumpForce;
			//theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
		}

		moveDirection.y = moveDirection.y + (Physics.gravity.y * Time.deltaTime);
		controller.Move (moveDirection * Time.deltaTime);
		cam.transform.position = new Vector3(rb2d.transform.position.x, cam.transform.position.y, cam.transform.position.z);
	}

	public void ChangeHealth(int amount){
		currentHealth += amount;
		currentHealth = Mathf.Clamp(currentHealth,0,maxHealth);
		healthFill.value = currentHealth/maxHealth;
	}
    public void agarrarHerramienta()
    {
        herramienta = true;
    }
    public bool getHerramienta()
    {
        return herramienta;
    }
}
