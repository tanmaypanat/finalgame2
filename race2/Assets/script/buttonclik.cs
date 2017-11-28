using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonclik : MonoBehaviour {

	public StreamVideo s1;
	public Button b1;
	public Button b2;

	void Start()
	{
		Button btn = b1.GetComponent<Button> ();
		btn.onClick.AddListener (Taskon);

		Button btn2 = b2.GetComponent<Button> ();
		btn2.onClick.AddListener (Taskon2);
	}

	void Taskon2()
	{
		Debug.Log ("click");
		s1.lclick ();

	}
	void Taskon()
	{
		Debug.Log ("click");
		s1.rclick ();

	}
	// Update is called once per frame

}
