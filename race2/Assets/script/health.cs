using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour {


	public Slider myhealth;
	public Slider opphealth;
	public GameObject img;
	public GameObject pwin;
	public GameObject cwin;

	// Use this for initialization
	void Start () {
		myhealth.value = 100;
		opphealth.value = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if(opphealth.value==0)
		{
			img.SetActive (true);
			pwin.SetActive (true);
	}
		if (myhealth.value == 0) {
			img.SetActive (true);
			cwin.SetActive (true);
		}
}
}