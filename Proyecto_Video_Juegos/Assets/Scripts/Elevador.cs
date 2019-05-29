using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour {
	
	public Transform pointA, pointB;
	private float speed;
	private int dir;

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.N)) {
			dir = 1;
        }
		
		if (Input.GetKeyDown(KeyCode.M)){
			dir = 0;
		}
		if (dir == 1){
		transform.position = Vector3.MoveTowards(transform.position, pointB.position,Time.deltaTime*30);
		} else
		if (dir == 0){
		transform.position = Vector3.MoveTowards(transform.position, pointA.position,Time.deltaTime*30);
		}
		
		print(transform.position);
		
	}
}
