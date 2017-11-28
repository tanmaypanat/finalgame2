using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthupp : MonoBehaviour {

	void OnTriggerEnter(Collider collision)
	{
		if(collision.CompareTag("Player"))
		{
			GameObject.FindGameObjectWithTag ("phealth").GetComponent<Slider> ().value += 20;
			Debug.Log ("playerhealth");
		}
		if (collision.CompareTag ("dream")) {
			GameObject.FindGameObjectWithTag ("opphealth").GetComponent<Slider> ().value += 20;
			Debug.Log ("dreamhealth");

		}

		Destroy (gameObject);
		Destroy (transform.parent.gameObject);
	}
}
