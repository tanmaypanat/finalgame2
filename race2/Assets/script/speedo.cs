using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedo : MonoBehaviour {

	public Rigidbody rb;
	public Text t1;
	public Rigidbody rb2;
	public Text t12;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		double mph=rb.velocity.magnitude*2.37;
		int k =(int) mph;
		t1.text =k+ " MPH";

		double mph2=rb2.velocity.magnitude*3.6;
		int k2 =(int) mph2;
		t12.text =k2+ " MPH";

	}
}
