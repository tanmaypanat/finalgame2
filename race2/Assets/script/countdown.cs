using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countdown : MonoBehaviour {


	public GameObject countd;
	public GameObject jk;
	// Use this for initialization
	void Start () {
		StartCoroutine (CountStart ());
		jk.SetActive (false);
	}
	IEnumerator CountStart()
	{


		yield return new WaitForSeconds (0.5f);
		countd.GetComponent<Text> ().text = "3";
		countd.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		countd.SetActive (false);
		countd.GetComponent<Text> ().text = "2";
		countd.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		countd.SetActive (false);
		countd.GetComponent<Text> ().text = "1";
		countd.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		countd.SetActive (false);
		countd.GetComponent<Text> ().text = "GO!";
		countd.SetActive (true);
		jk.SetActive (true);
		yield return new WaitForSeconds (0.5f);

		countd.SetActive (false);



	}

}
