using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manaup : MonoBehaviour {

	void OnTriggerEnter(Collider collision)
	{
		if(collision.CompareTag("Player"))
		{
			GameObject.FindGameObjectWithTag ("pmana").GetComponent<Slider> ().value += 20;
			Debug.Log ("playermana");
		}
		if (collision.CompareTag ("dream")) {
			GameObject.FindGameObjectWithTag ("oppmana").GetComponent<Slider> ().value += 20;
			Debug.Log ("dreammana");

		}

		Destroy (gameObject);
		Destroy (transform.parent.gameObject);
	}
}
