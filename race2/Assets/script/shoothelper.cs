using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoothelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (caller ());

	}
	public oppshooter opp;
	// Update is called once per frame
	IEnumerator caller()
	{
		yield return new WaitForSeconds (5f);
		if (GameObject.FindGameObjectWithTag ("oppmana").GetComponent<Slider> ().value > 0) {
			GameObject.FindGameObjectWithTag ("oppmana").GetComponent<Slider> ().value -= 10;
			opp.chalo ();

		}
		StartCoroutine (caller ());

	}
}
