using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text tiempoText;
	public float tiempo = 0.0f;
	
	void Start(){
		tiempoText = GetComponent<Text>();
	}
	void Update(){
		tiempo -=  Time.deltaTime;
		tiempoText.text = "" + tiempo.ToString("f0");
	}
}
