using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraa : MonoBehaviour {

	public GameObject front;
	public GameObject back;
	// Use this for initialization
	void start()
	{
		 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			//front.SetActive (false);
			back.SetActive (true);
		} 
		if (Input.GetKeyUp ("space")) {
			front.SetActive (true);
			back.SetActive (false);
		} 
	}
}
