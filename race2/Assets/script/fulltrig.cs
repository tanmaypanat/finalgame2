using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fulltrig : MonoBehaviour {

	public GameObject img;
	public GameObject pwin;
	public GameObject cwin;
	void OnCollisionEnter(Collision collison)
	{
		if(collison.collider.tag == "Player")
		{
			img.SetActive (true);
			pwin.SetActive (true);
		}
		if(collison.collider.tag == "dream")
		{
			img.SetActive (true);
			cwin.SetActive (true);
		}
			
	}
}
	