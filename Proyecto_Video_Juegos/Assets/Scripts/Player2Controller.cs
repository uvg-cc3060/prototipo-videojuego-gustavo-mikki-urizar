using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour  {

	public float moveSpeed;
	public float jumpForce;
	//public Rigidbody theRB;
	public CharacterController controller;
	public float gravityScale;
	private Vector3 moveDirection;

	// Use this for initialization
	void Start () {

		controller = GetComponent<CharacterController> ();
		//theRB = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update () {

		moveDirection = new Vector3 (Input.GetAxis ("Horizontal2") * moveSpeed, 0f, Input.GetAxis ("Vertical2") * moveSpeed);
		//theRB.velocity = new Vector3(Input.GetAxis ("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis ("Vertical") * moveSpeed);

		if (Input.GetButtonDown ("Jump")) 
		{

			moveDirection.y = jumpForce;
			//theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
		}

		moveDirection.y = moveDirection.y + (Physics.gravity.y * Time.deltaTime);
		controller.Move (moveDirection * Time.deltaTime);
	}
}
