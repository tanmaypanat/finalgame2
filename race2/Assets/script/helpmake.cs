using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpmake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public makob ma;
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0))
		{
			if (GameObject.FindGameObjectWithTag ("pmana").GetComponent<Slider> ().value > 0) {
				GameObject.FindGameObjectWithTag ("pmana").GetComponent<Slider> ().value -= 10;
				ma.makeit ();
			}
		}

	}
}
