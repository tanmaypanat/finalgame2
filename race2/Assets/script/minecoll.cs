using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minecoll : MonoBehaviour {

	void OnTriggerEnter(Collider collison)
	{
		if (collison.CompareTag("Player")) {
			GameObject.FindGameObjectWithTag ("phealth").GetComponent<Slider> ().value -= 5;

			Debug.Log ("boomboom");
			Destroy (gameObject);
		}



	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, 20);

	}
}
