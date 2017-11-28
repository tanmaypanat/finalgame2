using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oppshooter : MonoBehaviour {


	public Rigidbody riri;
	public float speed;
	// Use this for initialization
	public void chalo () {
		
		Vector3 j = new Vector3 (transform.position.x, 0.1f, transform.position.z + 1);
		Instantiate (riri,j,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
