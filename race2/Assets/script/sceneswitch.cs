﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneswitch : MonoBehaviour {

	public void MENU_ACTION_GoToPAGE(string scenename)
	{
		SceneManager.LoadScene (scenename);
	}
}
