using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coll : MonoBehaviour {



	void OnCollisionEnter(Collision collison)
	{
		if (collison.collider.tag == "dream") {
			GameObject.FindGameObjectWithTag ("opphealth").GetComponent<Slider> ().value -= 5;

			Debug.Log ("kaboom");
			Destroy (gameObject);
		}

			

	}
	void Update()
	{
		Destroy (gameObject, 0.5f);
	}

}
